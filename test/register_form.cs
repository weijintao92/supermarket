using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class register_form : Form
    {
        public register_form()
        {
            InitializeComponent();
        }

        //注册
        private void btn_ok_Click(object sender, EventArgs e)
        {
            string my_usernmae = txt_name.Text;
            string my_pwd = my_public.Get16MD5One(txt_pwd1.Text);

            if (txt_name.Text == "" || txt_pwd1.Text == "" || txt_pwd2.Text == "")
            {
                MessageBox.Show("账号和密码不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            if (txt_pwd1.Text != txt_pwd2.Text)
            {
                MessageBox.Show("两次输入的密码不一致！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

            string connecStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            // Console.WriteLine(strConnection);
            // string connecStr = "server=192.168.25.182;port=3307;database=test;user=root;password=123456";

            MySqlConnection conn = new MySqlConnection(connecStr);
            try
            {
                conn.Open();
                string sql_select = string.Format("select count(*) from user where user_name = '{0}'", my_usernmae);
                MySqlCommand mycmd = new MySqlCommand(sql_select, conn);
                Object result = mycmd.ExecuteScalar();//执行查询，并返回查询结果集中第一行的第一列。所有其他的列和行将被忽略。select语句无记录返回时，ExecuteScalar()返回NULL值
                if (Convert.ToInt32(result) > 0)
                {
                    MessageBox.Show("用户名重复！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    return;
                }
                string my_sql = string.Format("insert into user(user_name,pwd) values('{0}','{1}')", my_usernmae, my_pwd);
                MySqlCommand mycmd2 = new MySqlCommand(my_sql, conn);
                mycmd2.ExecuteNonQuery();
                MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

                conn.Close();
            }
        }
    }
}
