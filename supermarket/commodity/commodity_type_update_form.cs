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
using supermarket.Model;
using supermarket.my_calss;


namespace supermarket.commodity
{
    public partial class commodity_type_update_form : Form
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public commodity_type_update_form(Dictionary<string, string> dd)
        {
            InitializeComponent();
            dictionary = dd;
        }

        private void commodity_type_update_form_Load(object sender, EventArgs e)
        {
            

            txt_commodity_type.Text = dictionary["type"];


        }

        private void btn_save_Click(object sender, EventArgs e)
        {


            MySqlConnection conn = my_public.mysql_con();
            try
            {
                //conn.Open();
                string sql_insert = string.Format("UPDATE  commodity_type set type ='{0}' where id = {1}",txt_commodity_type.Text, dictionary["id"]);

                MySqlCommand mycmd2 = new MySqlCommand(sql_insert, conn);
                mycmd2.ExecuteNonQuery();
                MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                //删除dataGridView
                //dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                commodity_type_form commodity_Type_Form = (commodity_type_form)this.Owner;
                commodity_Type_Form.NewMethod();
                this.Dispose();

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
