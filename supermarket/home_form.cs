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
using MySql.Data.MySqlClient;
using supermarket.commodity;
using supermarket.my_calss;

namespace supermarket
{
    public partial class home_form : Form
    {
        public home_form()
        {
            InitializeComponent();
        }

        private string mytt = "请输入：条码/名称/简拼";
        //商品基础资料管理
        private void btn_commodity_Click(object sender, EventArgs e)
        {
            commodity_form commodity = new commodity_form();
            //this.Hide();
            commodity.Show();
        }

        private void home_form_Load(object sender, EventArgs e)
        {
            txt_condition.Text = mytt;


            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            id.Name = "id";
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            dataGridView.Columns.Add(id);

            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn();
            name.Name = "name";
            name.DataPropertyName = "name";
            name.HeaderText = "名称";
            dataGridView.Columns.Add(name);

            DataGridViewTextBoxColumn number = new DataGridViewTextBoxColumn();
            number.Name = "number";
            number.DataPropertyName = "number";
            number.HeaderText = "数量";
            dataGridView.Columns.Add(number);

            DataGridViewTextBoxColumn out_price = new DataGridViewTextBoxColumn();
            out_price.Name = "out_price";
            out_price.DataPropertyName = "out_price";
            out_price.HeaderText = "单价";
            dataGridView.Columns.Add(out_price);


            DataGridViewTextBoxColumn total = new DataGridViewTextBoxColumn();
            total.Name = "total";
            total.DataPropertyName = "total";
            total.HeaderText = "合计";
            dataGridView.Columns.Add(total);
            //int index = dataGridView>colum.Add();
            //this.dataGridView.Rows[index].Cells[0].Value = reader.GetInt32("id");
            //this.dataGridView.Rows[index].Cells[1].Value = reader.GetString("name");
            //this.dataGridView.Rows[index].Cells[2].Value = reader.GetString("out_price");


            //DataGridView dgv = this.dataGridView;
            //dgv.Columns[0].HeaderText = "id";
            //dgv.Columns[1].HeaderText = "名称";
            //dgv.Columns[2].HeaderText = "数量";
            //dgv.Columns[3].HeaderText = "售价";

            ////隐藏
            //dgv.Columns[0].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //获取到焦点时发生
        private void txt_condition_Enter(object sender, EventArgs e)
        {
            txt_condition.Clear();
            //txt_condition.BackColor = Color.White;
        }

        private void txt_condition_Leave(object sender, EventArgs e)
        {
            txt_condition.Text = mytt;
        }

        private void txt_condition_TextChanged(object sender, EventArgs e)
        {
            //判断是否输入
            if (txt_condition.Text == "" || txt_condition.Text == mytt)
            {
                return;
            }
              
            //判断是否为汉字
            if (my_public.IsChina(txt_condition.Text))
            {
               
                Console.WriteLine("输入结果为汉字！");
            }
            //字符串 条码
            else
            {
                //if (txt_condition.Text.Length < 5)
                //{
                //    Console.WriteLine("长度小于5！");
                //    return;
                //}
                //Console.WriteLine(444444444444444);
                string connecStr = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

                MySqlConnection conn = new MySqlConnection(connecStr);
                MySqlDataReader reader = null;
                try
                {
                    conn.Open();
                    string sql_select = string.Format("SELECT * FROM `commodity` where barcode = '{0}' and state = '1'", txt_condition.Text);
                    MySqlCommand mycmd = new MySqlCommand(sql_select, conn);
                    reader = mycmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("此商品不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    int my_coutn = 0;
                    DataTable dt = new DataTable("commodity");
                    dt.Columns.Add("id");
                    dt.Columns.Add("name");
                    dt.Columns.Add("out_price");
                    dt.Columns.Add("number");


                    while (reader.Read())//初始索引是-1，执行读取下一行数据，返回值是bool
                    {
                        dt.Rows.Add(reader.GetInt32("id"), reader.GetString("name"), reader.GetString("out_price"));
                        my_coutn = my_coutn + 1;
                        //Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString());
                        //Console.WriteLine(reader.GetInt32(0)+reader.GetString(1)+reader.GetString(2));
                        //Console.WriteLine(reader.GetInt32("userid") + reader.GetString("username") + reader.GetString("password"));//"userid"是数据库对应的列名，推荐这种方式
                        int index = dataGridView.Rows.Add();
                        this.dataGridView.Rows[index].Cells[0].Value = reader.GetInt32("id");
                        this.dataGridView.Rows[index].Cells[1].Value = reader.GetString("name");
                        this.dataGridView.Rows[index].Cells[2].Value = reader.GetString("out_price");
                    }

                    //if (my_coutn !=1) {
                    //    MessageBox.Show("此商品条码重复！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    return;
                    //}

                    //if (Convert.ToInt32(reader) == 0)
                    //{
                    //    MessageBox.Show("此商品无条码！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    //    return;
                    //}


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("数据库服务异常！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    reader.Close();
                    conn.Close();
                }
            }
        }
    }
}
