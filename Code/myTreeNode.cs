using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;



/* *******************************************
 * 作者 :  Guo MengWen
 * 文件名:  myTreeNode
 * 时间:   2014/9/12 17:20:24
 * 功能：重写TreeNode类
 * ******************************************/
namespace PasswordManage
{
    public class myTreeNode : TreeNode
    {
        private string NodeText = string.Empty;
        private int parentNode;
        public int ParentNode
        {
            get { return parentNode; }
            set { parentNode = value; }
        }
        private int nodeCode;
        public int NodeCode
        {
            get { return nodeCode; }
            set { nodeCode = value; }
        }
        public myTreeNode()
            : base()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public myTreeNode(string text, int _parentNode, int _nodeCode)
            : base(text, _parentNode, _nodeCode)
        {
            this.NodeCode = _nodeCode;
            this.ParentNode = _parentNode;
        }
    }
}
