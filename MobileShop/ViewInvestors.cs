using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class ViewInvestors : Form
    {
        public ViewInvestors()
        {
            InitializeComponent();
        }
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void ViewInvestors_Load(object sender, EventArgs e)
        {

            BindInvestors();
        }
        public void BindInvestors()
        {

            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from tbl_investors";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection(cs);
            string qry = "select * from  tbl_investors where investorname like '%" + searchTxt.Text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
