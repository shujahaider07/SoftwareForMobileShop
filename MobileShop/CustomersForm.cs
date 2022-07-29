using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            bindGridView();
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
            String qry = "exec sp_ViewCustomers";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(cs);
            string qry = "select * from  tbl_customers where Customername like '%" + Searchtxt.Text + "%' ";

            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void CustomersForm_Activated(object sender, EventArgs e)
        {
            bindGridView();
            styleGridView2();
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
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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

        private void Editbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(cs);
            var confirmResult = MessageBox.Show("Are you sure to Edit this item ??", "Confirm Edit!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                String qry = "update tbl_customers set customerName = '" + nametxt.Text + "' , phone = '" + phonetxt.Text + "' , address = '" + addtxt.Text + "' , openingbalance = '" + openingbalancetxt.Text + "' , customerCareOF = '" + caretxt.Text + "' , cnic = '" + InvestotcnicTXt.Text + "' where customerId = '" + customeridtxt.Text + "'   ";
                SqlCommand cmd = new SqlCommand(qry, sql);
                sql.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Edited");
                    bindGridView();
                }
                customeridtxt.Text = "";
                ClearCustomerData();
                sql.Close();

            }
            else
            {


            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            dataGridView1.CurrentRow.Selected = true;

            customeridtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            phonetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            InvestotcnicTXt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            caretxt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            openingbalancetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            addtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(cs);
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                String qry = "delete from tbl_Customers where customerid  = '" + customeridtxt.Text + "'  ";
                SqlCommand cmd = new SqlCommand(qry, sql);
                sql.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Deleted");
                    bindGridView();
                }

                sql.Close();

            }
            else
            {


            }





        }
    }
}
