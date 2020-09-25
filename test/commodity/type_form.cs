using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test.commodity
{
    public partial class type_form : Form
    {
        public type_form()
        {
            InitializeComponent();
        }

        //保存
        private void btn_save_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = my_public.mysql_con();
            try
            {
                //conn.Open();
                string sql_insert = string.Format("insert into `commodity_type`(type,state) VALUES('{0}','启用')", txt_type.Text);

                MySqlCommand mycmd2 = new MySqlCommand(sql_insert, conn);
                mycmd2.ExecuteNonQuery();
                MessageBox.Show("新增成功！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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

        private void strip_isable_Click(object sender, EventArgs e)
        {

        }

        private void type_view_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        //窗体加载
        private void type_form_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            MySqlConnection conn = my_public.mysql_con();
            try
            {
                //conn.Open();
                string sql_select = "select * from commodity_type";
                MySqlCommand mycmd = new MySqlCommand(sql_select, conn);
                MySqlDataReader reader = mycmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                DataTable my_dt = new DataTable();
                my_dt.Load(reader);
              
                type_view.DataSource = my_dt;
                DataGridView dgv = this.type_view;
                dgv.Columns[0].HeaderText = "id";
                dgv.Columns[1].HeaderText = "类型";
                dgv.Columns[2].HeaderText = "状态";

                //隐藏
                dgv.Columns[0].Visible = false;
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
    }
}
