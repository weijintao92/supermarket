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
using supermarket.my_calss;
using supermarket.Model;
using supermarket.commodity;

namespace supermarket.commodity
{
    public partial class commodity_type_form : Form
    {
        public commodity_type_form()
        {
            InitializeComponent();
        }

        //新增
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
            int index = this.dataGridView.Rows.Add();
            this.dataGridView.Rows[index].Cells[0].Value = "1";
            this.dataGridView.Rows[index].Cells[1].Value = "2";
            this.dataGridView.Rows[index].Cells[2].Value = "监听";
        }

        //禁用
        private void strip_isable_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentRow.Index;    //取得选中行的索引

            string id = dataGridView.Rows[index].Cells["Id"].Value.ToString();
            Console.WriteLine(id);
            MySqlConnection conn = my_public.mysql_con();
            try
            {
                //conn.Open();
                string sql_insert = string.Format("UPDATE  commodity_type set state = '禁用' where id = {0}", id);

                MySqlCommand mycmd2 = new MySqlCommand(sql_insert, conn);
                mycmd2.ExecuteNonQuery();
                MessageBox.Show("禁用成功！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                //删除dataGridView
                //dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);

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
        private void type_form_Load(object sender, EventArgs e)
        {
            NewMethod();
            //dataGridView.Rows[0].Selected = true;//默认选中第一行
        }

        public void NewMethod()
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
              
                dataGridView.DataSource = my_dt;
                DataGridView dgv = this.dataGridView;
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

        //编辑
        private void strip_update_Click(object sender, EventArgs e)
        {
            //dataGridView.ReadOnly = false;
            //Console.WriteLine(1111111111111111);
            //int index = dataGridView.CurrentRow.Index;
            ////dataGridView.Rows[index].DefaultCellStyle.BackColor = Color.DarkTurquoise;
            //DataGridViewCell cell = dataGridView.Rows[index].Cells[1];
            //dataGridView.CurrentCell = cell;
            //dataGridView.BeginEdit(true);
            //int index22 = dataGridView.CurrentCell.RowIndex;
            //if (index22 != -1)//判断是否选中某行
            //{
            //    MessageBox.Show("请鼠标左键单击，要修改的数据！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            //    return;
            //}
            Console.WriteLine();

            int index = dataGridView.CurrentRow.Index;    //取得选中行的索引
            string id = dataGridView.Rows[index].Cells["Id"].Value.ToString();
            string type = dataGridView.Rows[index].Cells["type"].Value.ToString();
            string state = dataGridView.Rows[index].Cells["state"].Value.ToString();
            //Commodity_Type commodity_Type = new Commodity_Type();
            //commodity_Type.Type = type;//保存传递的字符串
            //commodity_Type.Id = id ;//保存传递的字符串
            //commodity_Type.State = state;//保存传递的字符串
            //定义一个键值对集合
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //添加键值对数据,键必须唯一,值可重复
            dictionary.Add("id", id);
            dictionary.Add("type", type);
            dictionary.Add("state", state);
            commodity_type_update_form from = new commodity_type_update_form(dictionary);
            from.Owner = this;
            from.Show();
            
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine(e.RowIndex);
            if (e.RowIndex != -1)
            {
                this.dataGridView.CurrentCell = this.dataGridView.Rows[e.RowIndex].Cells[1];
            }
        }
    }
}
