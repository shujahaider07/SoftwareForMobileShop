using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class ReceiveBalance : Form
    {
        public ReceiveBalance()
        {
            InitializeComponent();
        }

        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void ReceiveBalance_Load(object sender, EventArgs e)
        {
            BindRecGrid();
            BindGridView();
            fetchReceiveID();
        }

        public void saveBill()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "insert into tbl_Receive values (@rid, @cid, @date, @amount, @description, @mobileID)";
            sql.Open();
            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.Parameters.AddWithValue("@rid", receiveIDTxt.Text);
            cmd.Parameters.AddWithValue("@cid", CustomerIdTXT.Text);
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@amount", receivingBalanceTxt.Text);
            cmd.Parameters.AddWithValue("@description", descriptionTxt.Text);
            cmd.Parameters.AddWithValue("@mobileID", mobileIDTxt.Text);

            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Inserted");
                BindGridView();
            }
            else
            {
                MessageBox.Show("Failed");
            }

            sql.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveBill();
        }

        private void Cnametxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (dataGridView2.Visible == false)
                {
                    dataGridView2.Visible = true;
                }
                else if (dataGridView2.Visible == true)
                {
                    dataGridView2.Visible = false;
                }
            }

        }

        public void BindRecGrid()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "exec sp_CustomerRemaining";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
            CustomerIdTXT.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            Cnametxt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            previousbalTxt.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            dataGridView2.Visible = false;
        }

        private void receivingBalanceTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double previousBal = Convert.ToDouble(previousbalTxt.Text);
                double receiveBal = Convert.ToDouble(receivingBalanceTxt.Text);

                double final = previousBal - receiveBal;

                remainingBalanceTxt.Text = final.ToString();


            }
        }

        public void BindGridView()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "exec sp_ViewReceived";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        public void fetchReceiveID()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select count(tbl_Receive.receiveID)+1 from tbl_Receive";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            receiveIDTxt.Text = dt.Rows[0][0].ToString();

        }
    }
}
