using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarket.my_calss
{
    public class my_public
    {

        /// <summary>
        /// 获取16位md5加密
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Get16MD5One(string source)
        {
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(source));
                //转换成字符串，并取9到25位
                string sBuilder = BitConverter.ToString(data, 4, 8);
                //BitConverter转换出来的字符串会在每个字符中间产生一个分隔符，需要去除掉
                sBuilder = sBuilder.Replace("-", "");
                return sBuilder.ToString().ToUpper();
            }
        }

        public static MySqlConnection mysql_con()
        {
            string connecStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            // Console.WriteLine(strConnection);
            // string connecStr = "server=192.168.25.182;port=3307;database=test;user=root;password=123456";

            MySqlConnection conn = new MySqlConnection(connecStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("数据库服务异常！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

            return conn;
        }
    }
}
