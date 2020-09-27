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

namespace supermarket.commodity
{
    public partial class commodity_form : Form
    {
        public commodity_form()
        {
            InitializeComponent();
        }

        //新增商品
        private void btn_add_Click(object sender, EventArgs e)
        {
            add_form add_Form = new add_form();
            //this.Hide();
            add_Form.Show();
        }

        private int start_count = 0;
        private int page_size = 1;
        //private int record = 0;
        private void commodity_form_Load(object sender, EventArgs e)
        {
            button_previous.Enabled = false;
            NewMethod();
            //DataTable dt = new DataTable();//建立个数据表

            //dt.Columns.Add(new DataColumn("id", typeof(int)));//在表中添加int类型的列

            //dt.Columns.Add(new DataColumn("Name", typeof(string)));//在表中添加string类型的Name列

            //DataRow dr;//行
            //for (int i = 0; i < 3; i++)
            //{
            //    dr = dt.NewRow();
            //    dr["id"] = i;
            //    dr["Name"] = "Name" + i;
            //    dt.Rows.Add(dr);//在表的对象的行里添加此行
            //}


        }

        private void NewMethod()
        {
            MySqlConnection conn = my_public.mysql_con();
            try
            {
                //conn.Open();
                string sql_select = string.Format("select * from commodity LIMIT {0},{1}", start_count, page_size);
                MySqlCommand mycmd = new MySqlCommand(sql_select, conn);
                MySqlDataReader reader = mycmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                DataTable my_dt = new DataTable();
                my_dt.Load(reader);
                if(my_dt.Rows.Count == 0)
                {
                    MessageBox.Show("已经是最后一页了！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    Console.WriteLine("未取到数据！");
                    button_next.Enabled = false;
                    return;
                }
                if (start_count > 0)
                {
                    button_previous.Enabled = true;

                }
                dataGridView.DataSource = my_dt;
                DataGridView dgv = this.dataGridView;
                dgv.Columns[0].HeaderText = "id";
                dgv.Columns[1].HeaderText = "名称";
                dgv.Columns[2].HeaderText = "编码";
                dgv.Columns[3].HeaderText = "进价";
                dgv.Columns[4].HeaderText = "售价";
                dgv.Columns[5].HeaderText = "类型";
                dgv.Columns[6].HeaderText = "数量";
                dgv.Columns[7].HeaderText = "状态";
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

        //下一页
        private void button1_Click(object sender, EventArgs e)
        {
           
            start_count = start_count + page_size;
            NewMethod();
        }

        //上一页
        private void button2_Click(object sender, EventArgs e)
        {
            button_next.Enabled = true;
            if (start_count == 0)
            {
                button_previous.Enabled = false;
                return;
         
            }
            start_count = start_count - page_size;

            NewMethod();
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dataGridView.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridView.ClearSelection();
                        dataGridView.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dataGridView.SelectedRows.Count == 1)
                    {
                        dataGridView.CurrentCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentRow.Index;    //取得选中行的索引
            string a = dataGridView.Rows[index].Cells["Id"].Value.ToString();
            Console.WriteLine(a);
        }

        //禁用
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentRow.Index;    //取得选中行的索引
            string id = dataGridView.Rows[index].Cells["Id"].Value.ToString();
            Console.WriteLine(id);
            MySqlConnection conn = my_public.mysql_con();
            try
            {
                //conn.Open();
                string sql_insert = string.Format("UPDATE  commodity set state = '禁用' where id = {0}", id);

                MySqlCommand mycmd2 = new MySqlCommand(sql_insert, conn);
                mycmd2.ExecuteNonQuery();
                MessageBox.Show("禁用成功！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                //删除dataGridView
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);

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
