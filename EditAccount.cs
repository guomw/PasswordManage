/* *******************************************
 * 作者 :  Guo MengWen
 * 文件名:  $classname$
 * 时间:   2014/9/13 14:49:00
 * 功能：添加用户帐号密码信息
 * ******************************************/

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
    public partial class EditAccount : Form
    {
        private int nodeCode { get; set; }
        private Main main { get; set; }
        private AccoutnModel accountModel { get; set; }
        private myTreeNode dfTree { get; set; }
        public EditAccount(Main m, myTreeNode myNode, AccoutnModel model = null)
        {
            InitializeComponent();
            dfTree = myNode;
            nodeCode = myNode.NodeCode;
            main = m;
            if (model == null)
                accountModel = new AccoutnModel();
            else
            {
                accountModel = model;

                txtAccountTitle.Text = accountModel.AccountTitle;
                txtAccoutnName.Text = accountModel.AccountName;
                txtAccountPwd.Text = accountModel.AccountPwd;
                txtAccountWebsite.Text = accountModel.AccountWebsite;
                txtAccountRemark.Text = accountModel.AccountRemark;
            }
            InitMcdTypeTree();
        }

        #region 关闭窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 编辑帐号信息
        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                txtAccountPwd.Clear();
                txtAccountRemark.Clear();
                txtAccountTitle.Clear();
                txtAccountWebsite.Clear();
                txtAccoutnName.Clear();
                txtAccountTitle.Focus();
            }

        }
        /// <summary>
        /// 保存并关闭窗口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            if (Save())
                this.Close();
        }

        /// <summary>
        /// 保存帐号信息
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            try
            {
                #region 文本框验证
                if (string.IsNullOrEmpty(txtAccountTitle.Text))
                {
                    txtAccountTitle.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtAccoutnName.Text))
                {
                    txtAccoutnName.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtAccountPwd.Text))
                {
                    txtAccountPwd.Focus();
                    return false;
                }
                #endregion

                Common comm = new Common();
                string path = comm.filePath("gridPath");
                DataTable dtGrid = comm.GetReadXml(path);
                if (accountModel.AccountCode <= 0)
                {
                    #region 添加数据
                    if (dtGrid == null)
                    {
                        dtGrid = new DataTable();
                        dtGrid.TableName = "AccountData";
                        dtGrid.Columns.Add("AccountCode", typeof(int));
                        dtGrid.Columns.Add("AccountTitle", typeof(string));
                        dtGrid.Columns.Add("AccountName", typeof(string));
                        dtGrid.Columns.Add("AccountPwd", typeof(string));
                        dtGrid.Columns.Add("AccountWebsite", typeof(string));
                        dtGrid.Columns.Add("AccountRemark", typeof(string));
                        dtGrid.Columns.Add("AccountAddTime", typeof(string));
                        dtGrid.Columns.Add("AccountGroupCode", typeof(int));
                    }
                    DataRow row = dtGrid.NewRow();
                    int accountCode = -1;
                    foreach (DataRow item in dtGrid.Rows)
                    {
                        int result = 0;
                        int.TryParse(item["AccountCode"].ToString(), out result);

                        if (result > accountCode)
                            accountCode = result;
                    }
                    row["AccountCode"] = accountCode > 0 ? accountCode + 1 : dtGrid.Rows.Count + 1;
                    row["AccountTitle"] = txtAccountTitle.Text;
                    row["AccountName"] = txtAccoutnName.Text;
                    row["AccountPwd"] = txtAccountPwd.Text;
                    row["AccountWebsite"] = txtAccountWebsite.Text;
                    row["AccountRemark"] = txtAccountRemark.Text;
                    row["AccountAddTime"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    myTreeNode myTree = this.cbxTree.TreeView.SelectedNode as myTreeNode;
                    row["AccountGroupCode"] = myTree != null ? myTree.NodeCode : dfTree.NodeCode;
                    dtGrid.Rows.Add(row);
                    #endregion
                }
                else //修改数据
                {
                    DataColumn[] myPrimaryKey = new DataColumn[1];
                    myPrimaryKey[0] = dtGrid.Columns["AccountCode"];
                    dtGrid.PrimaryKey = myPrimaryKey;
                    DataRow myEditDataRow = dtGrid.Rows.Find(accountModel.AccountCode);
                    myEditDataRow["AccountTitle"] = txtAccountTitle.Text;
                    myEditDataRow["AccountName"] = txtAccoutnName.Text;
                    myEditDataRow["AccountPwd"] = txtAccountPwd.Text;
                    myEditDataRow["AccountWebsite"] = txtAccountWebsite.Text;
                    myEditDataRow["AccountRemark"] = txtAccountRemark.Text;
                    myTreeNode myTree = this.cbxTree.TreeView.SelectedNode as myTreeNode;
                    myEditDataRow["AccountGroupCode"] = myTree != null ? myTree.NodeCode : dfTree.NodeCode;
                    dtGrid.AcceptChanges();
                }

                string gridXml = comm.CDataToXml(dtGrid);
                string filePath = System.IO.Path.Combine(Application.StartupPath, path);
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false);
                    sw.WriteLine(gridXml);
                    sw.Close();//写入
                }


                #region 加载gridview数据
                string _path = comm.filePath("treePath");
                DataTable dtTree = comm.GetReadXml(_path);
                //当前节点下的所有子节点ID   
                List<string> listCode = new List<string>();
                if (dtTree != null)
                {
                    listCode.Add(nodeCode.ToString());
                    DataRow[] dr_arr = dtTree.Select("parentNode='" + nodeCode + "'");
                    //获取当前选中节点下的所有节点ID
                    comm.SelectedTreeChild(dtTree, dr_arr, listCode);
                }

                main.LoadGridView(listCode);
                #endregion

                MessageBox.Show("保存成功！");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败！" + ex.Message);
                return false;
            }
        }
        #endregion








        /// <summary>
        /// 加载数节点数据
        /// </summary>
        public void InitMcdTypeTree()
        {
            Common comm = new Common();
            DataTable tvData = comm.GetReadXml(comm.filePath("treePath"));
            if (tvData != null)
            {
                TreeView treeView = this.cbxTree.TreeView;
                treeView.ImageList = imgList;
                treeView.Nodes.Clear();
                DataRow[] parent_arr = tvData.Select("parentNode='0'");
                foreach (DataRow dr in parent_arr)
                {
                    //作为一级层次  （根节点）
                    myTreeNode rootNode = new myTreeNode();
                    rootNode.Text = "默认";//dr["nodeTitle"].ToString();
                    rootNode.NodeCode = Convert.ToInt32(dr["nodeCode"].ToString());
                    rootNode.ParentNode = Convert.ToInt32(dr["parentNode"].ToString());
                    rootNode.SelectedImageIndex = 0;
                    rootNode.ImageIndex = 0;
                    treeView.Nodes.Add(rootNode);

                    if (accountModel != null)
                    {
                        if (accountModel.AccountGroupCode == rootNode.NodeCode)
                            dfTree = rootNode;
                    }
                    DataRow[] dr_arr = tvData.Select("parentNode='" + dr["nodeCode"].ToString() + "'");
                    addNode(tvData, dr_arr, rootNode);
                }
                treeView.ExpandAll();
                this.cbxTree.setTreeView(dfTree);
            }

        }
        /// <summary>
        /// 递归无限级菜单
        /// </summary>
        /// <param name="tvData"></param>
        /// <param name="dr_arr"></param>
        /// <param name="tn_origine"></param>
        private void addNode(DataTable tvData, DataRow[] dr_arr, myTreeNode tn_origine)
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
                    tn_sub.SelectedImageIndex = 1;
                    tn_sub.ImageIndex = 1;
                    DataRow[] child_arr = tvData.Select("parentNode='" + dr_sub["nodeCode"].ToString() + "'");
                    if (child_arr != null && child_arr.Length > 0)
                    {
                        tn_sub.SelectedImageIndex = 0;
                        tn_sub.ImageIndex = 0;
                    }

                    tn_origine.Nodes.Add(tn_sub);
                    if (accountModel != null)
                    {
                        if (accountModel.AccountGroupCode == tn_sub.NodeCode)
                            dfTree = tn_sub;
                    }
                    addNode(tvData, child_arr, tn_sub);
                }
            }
        }




    }
}
