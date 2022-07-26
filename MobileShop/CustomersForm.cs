using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MobileShop
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            Searchtxt.KeyUp += Searchtxt_KeyUp;
            

        }

        private void Searchtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                dataGridView1.RefreshEdit();    


            }
        }

        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddCustomer();
            FetchId();

        }

        public void AddCustomer()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "insert into tbl_Customers values (@customername , @phone , @address  , @openingbalance , @customercareOf , @cnic )";
            sql.Open();
            SqlCommand cmd = new SqlCommand(qry, sql);
            //cmd.Parameters.AddWithValue("@customerid", customeridtxt.Text);
            cmd.Parameters.AddWithValue("@customername", nametxt.Text);
            cmd.Parameters.AddWithValue("@phone", phonetxt.Text);
            cmd.Parameters.AddWithValue("@address", addtxt.Text);
            cmd.Parameters.AddWithValue("@openingbalance", openingbalancetxt.Text);
            cmd.Parameters.AddWithValue("@customercareOf", caretxt.Text);
            cmd.Parameters.AddWithValue("@cnic", InvestotcnicTXt.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Inserted");
                ClearCustomerData();
            }
            else
            {
                MessageBox.Show("failed");

            }


        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            FetchId();
            bindGridView();


        }

        public void bindGridView()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from tbl_customers";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(cs);
            string qry = "select * from  tbl_customers where Customername like '%"+ Searchtxt.Text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CustomersForm_Activated(object sender, EventArgs e)
        {
            bindGridView(); 
        }

   
       public void ClearCustomerData()
        {
            nametxt.Text = "";
            addtxt.Text = "";
            phonetxt.Text = "";
            openingbalancetxt.Text = "";
            caretxt.Text = "";
            InvestotcnicTXt.Text = "";


        }

        public void FetchId()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "selecT count(CustomerID)+1 as id from tbl_customers";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            customeridtxt.Text = dt.Rows[0][0].ToString();


        }

      
    }
}
