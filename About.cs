/* *******************************************
 * 作者 :  Guo MengWen
 * 文件名:  $classname$
 * 时间:   2014/9/16 13:28:27
 * 功能：
 * ******************************************/

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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
