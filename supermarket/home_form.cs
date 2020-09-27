using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using supermarket.commodity;

namespace supermarket
{
    public partial class home_form : Form
    {
        public home_form()
        {
            InitializeComponent();
        }

        //商品基础资料管理
        private void btn_commodity_Click(object sender, EventArgs e)
        {
            commodity_form commodity = new commodity_form();
            //this.Hide();
            commodity.Show();
        }

        private void home_form_Load(object sender, EventArgs e)
        {

        }
    }
}
