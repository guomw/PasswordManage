using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
//using System.Linq;
using System.Security.Cryptography;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;



/* *******************************************
 * 作者 :  Guo MengWen
 * 文件名:  Common
 * 时间:   2014/9/12 13:22:53
 * 功能：
 * ******************************************/
namespace PasswordManage.Code
{
    public class Common
    {

        /// <summary>
        /// 获取配置地址
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string filePath(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }

        #region MD5加密
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string MD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            byte[] result = md5.ComputeHash(data);
            String ret = "";
            for (int i = 0; i < result.Length; i++)
                ret += result[i].ToString("x").PadLeft(2, '0');
            return ret;
        }
        #endregion

        #region XML/DataTable 互转
        /// <summary>
        /// 获取xml数据并转换成datatable
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DataTable GetReadXml(string path)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, path);
                DataTable dt = new DataTable();

                if (File.Exists(filePath))
                {
                    FileStream aFile = new FileStream(filePath, FileMode.Open);
                    StreamReader sr = new StreamReader(aFile);
                    string xmlStr = sr.ReadToEnd();
                    sr.Close();
                    sr.Dispose();
                    aFile.Close();
                    aFile.Dispose();
                    DataSet ds = new DataSet();
                    // ds.ReadXml(filePath);
                    ds = XmlToDataSet(xmlStr);
                    dt = ds.Tables[0];
                    ds.Dispose();

                }
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 获取文件内容
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string GetFileText(string path)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, path);
                DataTable dt = new DataTable();

                if (File.Exists(filePath))
                {
                    FileStream aFile = new FileStream(filePath, FileMode.Open);
                    StreamReader sr = new StreamReader(aFile);
                    string str = sr.ReadToEnd();
                    sr.Close();
                    sr.Dispose();
                    aFile.Close();
                    aFile.Dispose();
                    return str;
                }
                return string.Empty;
            }
            catch (Exception)
            {
                return string.Empty;
            }

        }

        /// <summary>
        /// XML字符转换成DataSet
        /// </summary>
        /// <param name="xmlStr">xml字符串</param>
        /// <returns></returns>
        public DataSet XmlToDataSet(string xmlStr)
        {
            try
            {
                if (!string.IsNullOrEmpty(xmlStr))
                {
                    StringReader StrStream = null;
                    System.Xml.XmlTextReader Xmlrdr = null;
                    try
                    {
                        DataSet ds = new DataSet();
                        //读取字符串中的信息
                        StrStream = new StringReader(xmlStr);
                        //获取StrStream中的数据
                        Xmlrdr = new System.Xml.XmlTextReader(StrStream);
                        //ds获取Xmlrdr中的数据                
                        ds.ReadXml(Xmlrdr);

                        return ds;
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                    finally
                    {
                        //释放资源
                        if (Xmlrdr != null)
                        {
                            Xmlrdr.Close();
                            StrStream.Close();
                            StrStream.Dispose();
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// XML字符转换成DataTable
        /// </summary>
        /// <param name="xmlStr">xml字符串</param>
        /// <param name="tableName">datatable表名</param>
        /// <returns></returns>
        public DataTable XmlToDataTable(string xmlStr, string tableName)
        {
            try
            {
                if (!string.IsNullOrEmpty(xmlStr))
                {
                    DataTable dt = new DataTable();
                    DataSet ds = XmlToDataSet(xmlStr);
                    if (ds != null)
                    {
                        dt = ds.Tables[tableName];
                        return dt;
                    }
                    return null;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 将DataTable对象转换成XML字符串
        /// </summary>
        /// <param name="dt">DataTable对象</param>
        /// <returns>XML字符串</returns>
        public string CDataToXml(DataTable dt)
        {
            try
            {
                if (dt != null)
                {
                    MemoryStream ms = null;
                    System.Xml.XmlTextWriter XmlWt = null;
                    try
                    {
                        ms = new MemoryStream();
                        //根据ms实例化XmlWt
                        XmlWt = new XmlTextWriter(ms, Encoding.Unicode);
                        //获取ds中的数据
                        dt.WriteXml(XmlWt);
                        int count = (int)ms.Length;
                        byte[] temp = new byte[count];
                        ms.Seek(0, SeekOrigin.Begin);
                        ms.Read(temp, 0, count);
                        //返回Unicode编码的文本
                        UnicodeEncoding ucode = new UnicodeEncoding();
                        string returnValue = ucode.GetString(temp).Trim();
                        return returnValue;
                    }
                    catch (System.Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        //释放资源
                        if (XmlWt != null)
                        {
                            XmlWt.Close();
                            ms.Close();
                            ms.Dispose();
                        }
                    }
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }

        #endregion


        #region 获取当前节点下的所有节点ID

        public void SelectedTreeChild(DataTable dtTree, DataRow[] dr, List<string> listCode)
        {
            if (dr != null)
            {
                foreach (DataRow row in dr)
                {
                    int _nc = Convert.ToInt32(row["nodeCode"]);
                    listCode.Add(row["nodeCode"].ToString());
                    DataRow[] child_arr = dtTree.Select("parentNode='" + row["nodeCode"].ToString() + "'");
                    SelectedTreeChild(dtTree, child_arr, listCode);
                }
            }
        }
        #endregion

    }



}
