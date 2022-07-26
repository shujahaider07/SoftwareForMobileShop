using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MobileShop
{
    public partial class investor : Form
    {
        public investor()
        {
            InitializeComponent();
        }
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddCustomer();
            bindGridView();
            fetchID();
        }

        public void AddCustomer()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "insert into tbl_investors values (@id, @investorname , @investorphone , @investoraddress  , @investoropeningbalance , @investorcareOf , @cnic )";
            sql.Open();
            SqlCommand cmd = new SqlCommand(qry, sql);

            cmd.Parameters.AddWithValue("@id", Investoridtxt.Text);
            cmd.Parameters.AddWithValue("@investorname", Investornametxt.Text);
            cmd.Parameters.AddWithValue("@investorphone", Investorphonetxt.Text);
            cmd.Parameters.AddWithValue("@investoraddress", Investoraddtxt.Text);
            cmd.Parameters.AddWithValue("@investoropeningbalance", Invesotropeningbalancetxt.Text);
            cmd.Parameters.AddWithValue("@investorcareOf", investorcaretxt.Text);
            cmd.Parameters.AddWithValue("@cnic", cnicTXt.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Inserted");
                ClearInvestorData();
            }
            else
            {
                MessageBox.Show("failed");

            }



        }
        public void ClearInvestorData()
        {
            Investornametxt.Text = "";
            Investoraddtxt.Text = "";
            Investorphonetxt.Text = "";
            Invesotropeningbalancetxt.Text = "";
            investorcaretxt.Text = "";
            cnicTXt.Text = "";


        }

        public void bindGridView()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from tbl_investors";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void investor_Activated(object sender, EventArgs e)
        {
            bindGridView();
        }

        private void investor_Load(object sender, EventArgs e)
        {
            bindGridView();
            fetchID();
        }

        public void fetchID()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "selecT count(investorID)+1 as id from tbl_Investors";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Investoridtxt.Text = dt.Rows[0][0].ToString();
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(cs);
            string qry = "select * from  tbl_investors where investorname like '%" + Searchtxt.Text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
