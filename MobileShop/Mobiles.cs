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
            BindGrid();
            AddMobiles();


        }

        public void AddMobiles()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "insert into tbl_mobiles values (@mobileid,@mobilename, @mobileModel, @mobileIMEI, @purchaserate, @salerate, @investorID, @openingStock)";

            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.Parameters.AddWithValue("@mobileid", mobileidtxt.Text);
            cmd.Parameters.AddWithValue("@mobilename", mobilenametxt.Text);
            cmd.Parameters.AddWithValue("@mobileModel", ModelTxt.Text);
            cmd.Parameters.AddWithValue("@mobileIMEI", imeitxt.Text);
            cmd.Parameters.AddWithValue("@purchaserate", purchaseRatetxt.Text);
            cmd.Parameters.AddWithValue("@salerate", saleRatetxt.Text);
            cmd.Parameters.AddWithValue("@investorID", investornameCmb.SelectedValue);
            cmd.Parameters.AddWithValue("@openingStock", openingStocktxt.Text);


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
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
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

        private void mobilenametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            investor i = new investor();
            i.Show();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(cs);
            var confirmResult = MessageBox.Show("Are you sure to Edit this item ??", "Confirm Edit!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                String qry = "update tbl_Mobiles set mobileName = '" + mobilenametxt.Text + "' , purchaseRate = '" + purchaseRatetxt.Text + "', mobileimei = '"+imeitxt.Text+"' , Salerate = '" + saleRatetxt.Text + "' , MobileModel = '" + ModelTxt.Text + "' , openingStock = '" + openingStocktxt.Text + "' , investorId = '" + investornameCmb.Text + "' where mobileid = '" + mobileidtxt.Text + "'   ";
                SqlCommand cmd = new SqlCommand(qry, sql);
                sql.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Edited");
                    BindGrid();
                }
                mobileidtxt.Text = "";
                purchaseRatetxt.Text = "";
                saleRatetxt.Text = "";
                ModelTxt.Text = "";
                openingStocktxt.Text = "";
                investornameCmb.Text = "";
                imeitxt.Text = "";

                sql.Close();

            }
            else
            {


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            mobileidtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            mobilenametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            ModelTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            imeitxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            purchaseRatetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            saleRatetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            investornameCmb.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            openingStocktxt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(cs);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                String qry = "delete from tbl_mobiles where mobileId  = '" + mobileidtxt.Text + "'  ";
                SqlCommand cmd = new SqlCommand(qry, sql);
                sql.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Deleted");
                    BindGrid();              
                }

                sql.Close();

            }
            else
            {


            }

        }

        private void Mobiles_Activated(object sender, EventArgs e)
        {
            fetchInvestor();
        }
    }




}
