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
    }
}
