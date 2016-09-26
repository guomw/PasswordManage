using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;



/* *******************************************
 * 作者 :  Guo MengWen
 * 文件名:  ComboBoxTreeView
 * 时间:   2014/9/15 15:17:53
 * 功能： 自定义ComboBoxTreeView控件
 * ******************************************/
namespace PasswordManage.Code
{
    public class ComboBoxTreeView : ComboBox
    {
        private const int WM_LBUTTONDOWN = 0x201, WM_LBUTTONDBLCLK = 0x203;
        ToolStripControlHost treeViewHost;
        ToolStripDropDown dropDown;
        private int nodeCode;
        public int NodeCode { get { return nodeCode; } set { nodeCode = value; } }
        private int parentNode;
        public int ParentNode { get { return parentNode; } set { parentNode = value; } }
        public ComboBoxTreeView()
        {
            TreeView treeView = new TreeView();
            treeView.AfterSelect += new TreeViewEventHandler(treeView_AfterSelect);
            treeView.BorderStyle = BorderStyle.None;
            treeView.ShowLines = true;
            treeView.ShowNodeToolTips = false;
            treeView.ShowPlusMinus = false;
            treeView.ShowRootLines = false;
            treeViewHost = new ToolStripControlHost(treeView);
            dropDown = new ToolStripDropDown();
            dropDown.Width = this.Width;
            dropDown.Items.Add(treeViewHost);
        }
        /// <summary>
        /// 选择中时触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            myTreeNode myTree = TreeView.SelectedNode as myTreeNode;
            this.Text = myTree.Text;
            this.NodeCode = myTree.NodeCode;
            this.ParentNode = myTree.ParentNode;
            dropDown.Close();
        }
        /// <summary>
        /// 设置默认选择值
        /// </summary>
        /// <param name="myNode"></param>
        public void setTreeView(myTreeNode myNode)
        {
            this.Text = myNode.Text;
            this.NodeCode = myNode.NodeCode;
            this.ParentNode = myNode.ParentNode;
        }

        public TreeView TreeView
        {
            get { return treeViewHost.Control as TreeView; }
        }
        private void ShowDropDown()
        {
            if (dropDown != null)
            {
                treeViewHost.Size = new System.Drawing.Size(DropDownWidth - 2, DropDownHeight);
                dropDown.Show(this, 0, this.Height);
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDBLCLK || m.Msg == WM_LBUTTONDOWN)
            {
                ShowDropDown();
                return;
            }
            base.WndProc(ref m);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dropDown != null)
                {
                    dropDown.Dispose();
                    dropDown = null;
                }
            }
            base.Dispose(disposing);
        }
    }
}
