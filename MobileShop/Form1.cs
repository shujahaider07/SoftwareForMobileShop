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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CustomersForm cf = new CustomersForm();
            cf.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomersForm cf = new CustomersForm();
            cf.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CustomerView cv = new CustomerView();
            cv.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            CustomerView cv = new CustomerView();
            cv.ShowDialog(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Mobiles m = new Mobiles();
            m.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mobiles m = new Mobiles();
            m.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            investor i = new investor();
            i.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            investor i = new investor();
            i.Show(); 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }
    }
}
