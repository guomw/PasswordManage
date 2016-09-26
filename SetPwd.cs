/* *******************************************
 * 作者 :  Guo MengWen
 * 文件名:  $classname$
 * 时间:   2014/9/16 10:58:05
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
    public partial class SetPwd : Form
    {
        private bool IsSetPwd { get; set; }
        private Main main { get; set; }
        public SetPwd(Main _main, bool _issetpwd = false)
        {
            InitializeComponent();
            this.main = _main;
            IsSetPwd = _issetpwd;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Common com = new Common();
            string path = com.filePath("configPath");
            string pwdStr = com.MD5(string.IsNullOrEmpty(txtPwd.Text) ? "0|-1" : "1|" + txtPwd.Text.Trim());
            if (this.IsSetPwd)
            {
                string filePath = System.IO.Path.Combine(Application.StartupPath, path);
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false);
                    sw.Write(pwdStr);
                    sw.Close();//写入
                    MessageBox.Show("设置密码成功!");
                    this.Close();
                }
            }
            else
            {
                string str = com.GetFileText(path);
                if (!string.IsNullOrEmpty(str))
                {
                    if (str.ToString().Trim() == pwdStr)
                    {
                        this.main.LoadTreeView();
                        //this.main.LoadGridView();
                        this.Close();
                    }
                    else
                        MessageBox.Show("密码错误!");

                }
            }
        }
        #region 关闭窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.IsSetPwd)
                this.Close();
            else
                Application.Exit();
        }

        private void SetPwd_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Close();

        }
        #endregion
    }
}
