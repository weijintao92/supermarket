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

namespace test.commodity
{
    public partial class add_form : Form
    {
        public add_form()
        {
            InitializeComponent();
        }

        //新增商品
        private void btn_ok_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(combox_tpye.Text);
            //Console.WriteLine(combox_state.Text);
            MySqlConnection conn = my_public.mysql_con();
            try
            {
                //conn.Open();
                string sql_insert = string.Format("INSERT into commodity(name, barcode, in_price, out_price, type, state) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txt_name.Text, txt_barcode.Text, txt_inPrice.Text, txt_outPrice.Text, combox_tpye.Text, combox_state.Text);
               
                MySqlCommand mycmd2 = new MySqlCommand(sql_insert, conn);
                mycmd2.ExecuteNonQuery();
                MessageBox.Show("成功！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

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

        //窗体加载
        private void add_form_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = my_public.mysql_con();
            try
            {
                //conn.Open();
                string sql_select = "select * from commodity_type where state = '正常'";
                MySqlCommand mycmd = new MySqlCommand(sql_select, conn);
                MySqlDataReader reader = mycmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                while (reader.Read())//初始索引是-1，执行读取下一行数据，返回值是bool
                {
                    //Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString());
                    //Console.WriteLine(reader.GetInt32(0)+reader.GetString(1)+reader.GetString(2));
                    Console.WriteLine(reader.GetString("type"));//"userid"是数据库对应的列名，推荐这种方式
                    combox_tpye.Items.Add(reader.GetString("type"));
                }

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
            combox_tpye.SelectedIndex = 0;
        }

        private void combox_state_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
