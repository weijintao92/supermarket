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

namespace test
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

        private void button1_Click(object sender, EventArgs e)
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
    }
}
