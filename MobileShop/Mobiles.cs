using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class Mobiles : Form
    {
        public Mobiles()
        {
            InitializeComponent();
        }
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FetchMobileId();
            AddMobiles();


        }

        public void AddMobiles()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "insert into tbl_mobiles values (@mobilename , @mobileiemi, @purchaserate , @mobileModel ,@openingStock , @investorID , @salerate)";

            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.Parameters.AddWithValue("@mobilename", mobilenametxt.Text);
            cmd.Parameters.AddWithValue("@purchaserate", purchaseRatetxt.Text);
            cmd.Parameters.AddWithValue("@salerate", saleRatetxt.Text);
            cmd.Parameters.AddWithValue("@mobileModel", ModelTxt.Text);
            cmd.Parameters.AddWithValue("@openingStock", openingStocktxt.Text);
            cmd.Parameters.AddWithValue("@investorID", investornameCmb.SelectedValue);
            cmd.Parameters.AddWithValue("@mobileiemi", imeitxt.Text);


            sql.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("inserted");
            }
            else
            {
                MessageBox.Show("inserted failed");

            }

            sql.Close();


        }


        public void FetchMobileId()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select count(mobileid)+1 from tbl_mobiles";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mobileidtxt.Text = dt.Rows[0][0].ToString();


        }

        public void styleGridView2()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Teal;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Empty;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Empty;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = true;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("calibri", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        private void Mobiles_Load(object sender, EventArgs e)
        {
            BindGrid();
            styleGridView2();
            FetchMobileId();
            fetchInvestor();
        }

        public void fetchInvestor()
        {
            SqlConnection sql = new SqlConnection(cs);
            sql.Open();
            string qry = "select investorID, investorName from tbl_Investors";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            investornameCmb.DisplayMember = "investorName";
            investornameCmb.ValueMember = "investorID";
            investornameCmb.DataSource = dt;
            sql.Close();
        }

        private void investornameCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string insID = investornameCmb.SelectedItem.ToString().Substring(0, 1);
        }

        private void mobpricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void BindGrid()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from tbl_mobiles";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from  tbl_mobiles where mobileName like '%" + Searchtxt.Text + "%' ";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
