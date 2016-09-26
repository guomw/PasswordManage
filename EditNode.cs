/* *******************************************
 * 作者 :  Guo MengWen
 * 文件名:  $classname$
 * 时间:   2014/9/12 15:22:44
 * 功能：
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
    public partial class EditNode : Form
    {
        private int parentNode { get; set; }
        private int nodeCode { get; set; }
        private string nodeText { get; set; }
        public int currentSelectedNode { get; set; }
        private Main main { get; set; }
        public EditNode(Main m, int pid, int nid = 0, string text = "")
        {
            InitializeComponent();
            parentNode = pid;
            nodeCode = nid;
            nodeText = text;
            main = m;
            txtNodeTitle.Text = text;
        }
        #region 关闭窗体
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EditNode_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        } 
        #endregion
        /// <summary>
        /// 编辑节点时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNodeTitle.Text))
                    return;
                Common comm = new Common();
                DataTable dtTree = comm.GetReadXml(comm.filePath("treePath"));
                if (nodeCode <= 0)
                {
                    if (parentNode == 0)
                        return;
                    #region 添加节点
                    DataRow row = dtTree.NewRow();
                    row["nodeCode"] = Convert.ToInt32(dtTree.Rows[dtTree.Rows.Count-1]["nodeCode"]) + 1;
                    row["parentNode"] = parentNode;
                    row["nodeTitle"] = txtNodeTitle.Text;
                    dtTree.Rows.Add(row);
                    #endregion
                }
                else
                {
                    DataColumn[] myPrimaryKey = new DataColumn[1];
                    myPrimaryKey[0] = dtTree.Columns["nodeCode"];
                    dtTree.PrimaryKey = myPrimaryKey;
                    DataRow myEditDataRow = dtTree.Rows.Find(nodeCode);
                    myEditDataRow["nodeTitle"] = txtNodeTitle.Text;
                    dtTree.AcceptChanges();
                }

                string treeXml = comm.CDataToXml(dtTree);
                string filePath = System.IO.Path.Combine(Application.StartupPath, comm.filePath("treePath"));
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false);
                    sw.WriteLine(treeXml);
                    sw.Close();//写入
                }
                main.LoadTreeView(currentSelectedNode);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
