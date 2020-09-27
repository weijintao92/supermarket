using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using supermarket.my_calss;

namespace supermarket
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private static void NewMethod(MySqlConnection conn)
        {
            try
            {
                conn.Open();
                MySqlCommand mycmd = new MySqlCommand("select * from user", conn);
                MySqlDataReader mdr = mycmd.ExecuteReader();
                while (mdr.Read())
                {
                    for (int i = 0; i < mdr.FieldCount; ++i)
                    {
                        Console.WriteLine(mdr.GetValue(i));
                    }
                }

                mdr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {

                conn.Close();
            }
            // Console.ReadKey();
        }

        // 登陆
        private void btn_login_Click(object sender, EventArgs e)
        {
            home_form anotherForm = new home_form();
            //this.Hide();
            anotherForm.Show();
            //Application.ExitThread();

            string connecStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            // Console.WriteLine(strConnection);
            // string connecStr = "server=192.168.25.182;port=3307;database=test;user=root;password=123456";
            MySqlConnection conn = new MySqlConnection(connecStr);
            NewMethod(conn);
        }



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

        //登录
        private void Btn_login_Click_1(object sender, EventArgs e)
        {
            string my_usernmae = txt_name.Text;
            string my_pwd = my_public.Get16MD5One(txt_pwd.Text);

            if (txt_name.Text == "" || txt_pwd.Text == "")
            {
                MessageBox.Show("账号和密码不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }


            string connecStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            // Console.WriteLine(strConnection);
            // string connecStr = "server=192.168.25.182;port=3307;database=test;user=root;password=123456";

            MySqlConnection conn = new MySqlConnection(connecStr);
            try
            {
                conn.Open();
                string sql_select = string.Format("select count(*) from user where user_name = '{0}' and pwd = '{1}'",my_usernmae, my_pwd);
                MySqlCommand mycmd = new MySqlCommand(sql_select, conn);
                Object result = mycmd.ExecuteScalar();//执行查询，并返回查询结果集中第一行的第一列。所有其他的列和行将被忽略。select语句无记录返回时，ExecuteScalar()返回NULL值
                if (Convert.ToInt32(result) == 0)
                {
                    MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    return;
                }
                home_form home_Form = new home_form();
                this.Hide();
                home_Form.Show();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("数据库服务异常！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            finally
            {

                conn.Close();
            }
        }

        //注册
        private void Btn_register_Click_1(object sender, EventArgs e)
        {


            register_form register = new register_form();
            //this.Hide();
            register.Show();


        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
