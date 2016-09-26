using PasswordManage.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManage
{
    public partial class Main : Form
    {
        private myTreeNode selectedNode { get; set; }
        private Common _provider = new Common();
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗口关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 窗口加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            selectedNode = new myTreeNode();
            string str = _provider.GetFileText(_provider.filePath("configPath"));
            if (!string.IsNullOrEmpty(str))
            {
                string pwd = _provider.MD5("0|-1");
                if (str == pwd)
                {
                    LoadTreeView();
                }
                else
                {
                    SetPwd sp = new SetPwd(this);
                    sp.ShowDialog(this);
                }
            }
            else
                Application.Exit();
        }

        #region 数据绑定
        /// <summary>
        /// 加载数节点数据
        /// </summary>
        public void LoadTreeView(int selectedNodeCode = 1)
        {
            DataTable tvData = _provider.GetReadXml(_provider.filePath("treePath"));
            if (tvData != null)
            {
                this.tvNodes.Nodes.Clear();
                DataRow[] parent_arr = tvData.Select("parentNode='0'");
                foreach (DataRow dr in parent_arr)
                {
                    //作为一级层次  （根节点）
                    myTreeNode root = new myTreeNode();
                    root.Text = dr["nodeTitle"].ToString();
                    root.NodeCode = Convert.ToInt32(dr["nodeCode"].ToString());
                    root.ParentNode = Convert.ToInt32(dr["parentNode"].ToString());
                    root.ContextMenuStrip = tvNodeAddParent;
                    root.SelectedImageIndex = 4;
                    root.ImageIndex = 4;
                    this.tvNodes.Nodes.Add(root);
                    selectedNode = root.NodeCode == selectedNodeCode ? root : selectedNode;
                    DataRow[] dr_arr = tvData.Select("parentNode='" + root.NodeCode + "'");
                    LoadChildTreeData(tvData, dr_arr, root, selectedNodeCode);

                }
            }
            this.tvNodes.ExpandAll();
            selectedNode.Checked = true;
            this.tvNodes.SelectedNode = selectedNode;
            TreeNodeSelected(selectedNode);
        }
        /// <summary>
        /// 递归无限级菜单
        /// </summary>
        /// <param name="tvData"></param>
        /// <param name="dr_arr"></param>
        /// <param name="tn_origine"></param>
        private void LoadChildTreeData(DataTable tvData, DataRow[] dr_arr, myTreeNode tn_origine, int selectedNodeCode)
        {
            if (dr_arr.Length > 0)
            {
                //下一级层次
                foreach (DataRow dr_sub in dr_arr)
                {
                    myTreeNode tn_sub = new myTreeNode();
                    tn_sub.Text = dr_sub["nodeTitle"].ToString();
                    tn_sub.NodeCode = Convert.ToInt32(dr_sub["nodeCode"].ToString());
                    tn_sub.ParentNode = Convert.ToInt32(dr_sub["parentNode"].ToString());
                    tn_sub.ContextMenuStrip = tvNodeAdd;
                    tn_sub.SelectedImageIndex = 5;
                    tn_sub.ImageIndex = 5;
                    DataRow[] child_arr = tvData.Select("parentNode='" + tn_sub.NodeCode + "'");
                    if (child_arr != null && child_arr.Length > 0)
                    {
                        tn_sub.SelectedImageIndex = 4;
                        tn_sub.ImageIndex = 4;
                    }
                    tn_origine.Nodes.Add(tn_sub);
                    selectedNode = tn_sub.NodeCode == selectedNodeCode ? tn_sub : selectedNode;
                    LoadChildTreeData(tvData, child_arr, tn_sub, selectedNodeCode);
                }
            }
        }

        /// <summary>
        /// 加载GridView 数据
        /// </summary>
        /// <param name="groupid"></param>
        public void LoadGridView(List<string> listCode = null)
        {
            new System.Threading.Thread(delegate()
            {
                //是否自动添加属性字段
                this.dgvData.AutoGenerateColumns = false;
                DataTable dt = _provider.GetReadXml(_provider.filePath("gridPath"));
                if (dt != null)
                {
                    if (listCode != null && listCode.Count > 0)
                    {
                        //string joinStr = "AccountGroupCode in(";
                        //foreach (string item in listCode)
                        //{
                        //    joinStr += item + ",";
                        //}
                        //joinStr = joinStr.Substring(0, joinStr.Length - 1) + ")";

                        DataRow[] dr_arr = dt.Select(string.Format("AccountGroupCode in({0})", string.Join(",", listCode)));
                        if (dr_arr != null && dr_arr.Length > 0)
                            dt = dr_arr.CopyToDataTable();
                        else
                            dt = null;
                    }
                }
                if (dt == null)
                    dgvData.ContextMenuStrip = null;
                else
                    dgvData.ContextMenuStrip = gridMenu;
                SetGridViewData(dt);

            }) { IsBackground = true }.Start();
        }
        #endregion


        #region 节点操作事件
        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMenuAddParentNode_Click(object sender, EventArgs e)
        {
            myTreeNode tn = tvNodes.SelectedNode as myTreeNode;
            if (tn == null) return;
            if (tn.ParentNode == 0)
                return;
            EditNode editnode = new EditNode(this, tn.ParentNode);
            editnode.currentSelectedNode = tn.NodeCode;
            editnode.ShowDialog(this);
        }
        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMenuAddChildNode_Click(object sender, EventArgs e)
        {
            myTreeNode tn = tvNodes.SelectedNode as myTreeNode;
            if (tn == null) return;
            EditNode editnode = new EditNode(this, tn.NodeCode);
            editnode.currentSelectedNode = tn.NodeCode;
            editnode.ShowDialog(this);
        }
        /// <summary>
        /// 修改节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvNodeUpdateNode_Click(object sender, EventArgs e)
        {
            myTreeNode tn = tvNodes.SelectedNode as myTreeNode;
            if (tn == null) return;
            EditNode editnode = new EditNode(this, tn.ParentNode, tn.NodeCode, tn.Text);
            editnode.currentSelectedNode = tn.NodeCode;
            editnode.ShowDialog(this);
        }
        /// <summary>
        /// 删除分组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvNodeDelete_Click(object sender, EventArgs e)
        {
            myTreeNode tn = tvNodes.SelectedNode as myTreeNode;
            if (tn == null || tn.NodeCode == 1) return;
            if (MessageBox.Show("您确认要删除分组【" + tn.Text + "】以及下面的所有分组吗？", "删除提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string path = _provider.filePath("treePath");
                DataTable dtTree = _provider.GetReadXml(path);
                if (dtTree != null)
                {
                    DataColumn[] myPrimaryKey = new DataColumn[1];
                    myPrimaryKey[0] = dtTree.Columns["nodeCode"];
                    dtTree.PrimaryKey = myPrimaryKey;
                    DataRow myEditDataRow = dtTree.Select("nodeCode=" + tn.NodeCode)[0];// dtTree.Rows.Find(tn.NodeCode);
                    //int _nodeCode = Convert.ToInt32(myEditDataRow["nodeCode"]);
                    myEditDataRow.Delete();

                    //删除当前节点下的所有子节点
                    DataRow[] dr_arr = dtTree.Select("parentNode=" + tn.NodeCode);
                    deleteNode(dtTree, dr_arr);

                    dtTree.AcceptChanges();
                    string treeXml = _provider.CDataToXml(dtTree);
                    string filePath = System.IO.Path.Combine(Application.StartupPath, path);
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false);
                        sw.WriteLine(treeXml);
                        sw.Close();//写入
                    }
                }
                LoadTreeView();
            }
        }
        /// <summary>
        /// 删除所有子节点
        /// </summary>
        /// <param name="dtTree"></param>
        /// <param name="dr_arr"></param>
        /// <param name="nodeCode"></param>
        private static void deleteNode(DataTable dtTree, DataRow[] dr_arr)
        {
            if (dr_arr != null)
            {
                foreach (DataRow dr in dr_arr)
                {
                    DataColumn[] _myPrimaryKey = new DataColumn[1];
                    _myPrimaryKey[0] = dtTree.Columns["nodeCode"];
                    dtTree.PrimaryKey = _myPrimaryKey;
                    DataRow _myEditDataRow = dtTree.Rows.Find(dr["nodeCode"]);
                    int __nodeCode = Convert.ToInt32(_myEditDataRow["nodeCode"]);
                    _myEditDataRow.Delete();
                    DataRow[] child_arr = dtTree.Select("parentNode='" + __nodeCode + "'");
                    deleteNode(dtTree, child_arr);
                }
            }
        }
        /// <summary>
        /// 鼠标单击节点时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvNodes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            myTreeNode tn = e.Node as myTreeNode;
            TreeNodeSelected(tn);
            this.tvNodes.SelectedNode = tn;
        }

        private void TreeNodeSelected(myTreeNode tn)
        {
            if (!string.IsNullOrEmpty(tn.Text))
            {
                if (tn.ParentNode != 0)
                {
                    string path = _provider.filePath("treePath");
                    DataTable dtTree = _provider.GetReadXml(path);
                    //当前节点下的所有子节点ID   
                    List<string> listCode = new List<string>();
                    if (dtTree != null)
                    {
                        listCode.Add(tn.NodeCode.ToString());
                        DataRow[] dr_arr = dtTree.Select("parentNode='" + tn.NodeCode + "'");
                        //获取当前选中节点下的所有节点ID
                        _provider.SelectedTreeChild(dtTree, dr_arr, listCode);
                    }
                    LoadGridView(listCode);
                }
                else
                    LoadGridView();
            }
            else
                LoadGridView();
        }




        #endregion


        private void ShowAccountForm()
        {
            myTreeNode tn = tvNodes.SelectedNode as myTreeNode;
            if (tn == null) return;
            EditAccount account = new EditAccount(this, tn);
            account.ShowDialog();
        }


        /// <summary>
        /// GridView数据绑定
        /// </summary>
        /// <param name="data"></param>
        private void SetGridViewData(object data)
        {
            if (this.dgvData.InvokeRequired)
            {
                this.Invoke(new Action<object>(SetGridViewData), new object[] { data });
            }
            else
            {
                this.dgvData.DataSource = data;
                this.dgvData.Refresh();
            }
        }


        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 新建事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCreateAccount_Click(object sender, EventArgs e)
        {
            ShowAccountForm();
        }

        #region 修改/删除GridView 数据

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource != null)
            {
                DataGridViewCellCollection row = dgvData.CurrentRow.Cells;
                if (MessageBox.Show("您确认要删除标题为【" + row[1].Value + "】的数据吗？", "删除提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string path = _provider.filePath("gridPath");
                    DataTable dtGrid = _provider.GetReadXml(path);
                    DataColumn[] myPrimaryKey = new DataColumn[1];
                    myPrimaryKey[0] = dtGrid.Columns["AccountCode"];
                    dtGrid.PrimaryKey = myPrimaryKey;
                    DataRow myEditDataRow = dtGrid.Rows.Find(row[0].Value);
                    myEditDataRow.Delete();
                    dtGrid.AcceptChanges();
                    string gridXml = _provider.CDataToXml(dtGrid);
                    string filePath = System.IO.Path.Combine(Application.StartupPath, path);
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false);
                        sw.WriteLine(gridXml);
                        sw.Close();//写入
                    }


                    myTreeNode tn = tvNodes.SelectedNode as myTreeNode;
                    string _path = _provider.filePath("treePath");
                    DataTable dtTree = _provider.GetReadXml(_path);
                    //当前节点下的所有子节点ID   
                    List<string> listCode = new List<string>();
                    if (dtTree != null)
                    {
                        listCode.Add(tn.NodeCode.ToString());
                        DataRow[] dr_arr = dtTree.Select("parentNode='" + tn.NodeCode + "'");
                        //获取当前选中节点下的所有节点ID
                        _provider.SelectedTreeChild(dtTree, dr_arr, listCode);
                    }

                    LoadGridView(listCode);
                }
            }
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridUpdate_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource != null)
            {
                DataGridViewCellCollection row = dgvData.CurrentRow.Cells;
                if (row.Count > 5)
                {
                    AccoutnModel model = new AccoutnModel();
                    model.AccountCode = Convert.ToInt32(row[0].Value);
                    model.AccountTitle = row[1].Value.ToString();
                    model.AccountName = row[2].Value.ToString();
                    model.AccountPwd = row[3].Value.ToString();
                    model.AccountWebsite = row[4].Value.ToString();
                    model.AccountRemark = row[5].Value.ToString();
                    model.AccountGroupCode = Convert.ToInt32(row[6].Value);
                    myTreeNode tn = tvNodes.SelectedNode as myTreeNode;

                    EditAccount account = new EditAccount(this, tn, model);
                    account.ShowDialog();
                }
            }
        }
        #endregion

        private void tsbCollapsed_Click(object sender, EventArgs e)
        {
            if (sContainer.Panel1Collapsed)
            {
                sContainer.Panel1Collapsed = false;
                tsbCollapsed.Text = "收缩";
            }
            else
            {
                sContainer.Panel1Collapsed = true;
                tsbCollapsed.Text = "展开";
            }
        }
        /// <summary>
        /// 设置密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSetPwd_Click(object sender, EventArgs e)
        {
            SetPwd sp = new SetPwd(this, true);
            sp.ShowDialog(this);
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
    }
}
