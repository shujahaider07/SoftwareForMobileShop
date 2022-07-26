using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }


        private void CustomerView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mobileShopDataSet.tbl_Customers' table. You can move, or remove it, as needed.
            this.tbl_CustomersTableAdapter.Fill(this.mobileShopDataSet.tbl_Customers);

        }
    }
}
