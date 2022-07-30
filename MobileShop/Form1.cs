using System;
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

        private void label6_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            ViewSales s = new ViewSales();
            s.Show();
        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {
            ViewSales s = new ViewSales();
            s.Show();
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ReceiveBalance receiveBalance = new ReceiveBalance();
            receiveBalance.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemainingCustomerBalance frm = new RemainingCustomerBalance();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InvestorRemaining frm = new InvestorRemaining();
            frm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ViewInvestors vi = new ViewInvestors();
            vi.Show();
        }
    }
}
