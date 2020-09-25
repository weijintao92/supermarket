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
    }
}
