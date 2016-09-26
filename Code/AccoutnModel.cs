using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;



/* *******************************************
 * 作者 :  Guo MengWen
 * 文件名:  AccoutnModel
 * 时间:   2014/9/13 17:00:03
 * 功能：
 * ******************************************/
namespace PasswordManage.Code
{
    public class AccoutnModel
    {
        public int AccountCode { get; set; }
        public string AccountTitle { get; set; }
        public string AccountName { get; set; }
        public string AccountPwd { get; set; }
        public string AccountRemark { get; set; }
        public string AccountWebsite { get; set; }
        public int AccountGroupCode { get; set; }

    }
}
