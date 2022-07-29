using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (dataGridView1.Visible == false)
                {
                    dataGridView1.Visible = true;
                }
                else if (dataGridView1.Visible == true)
                {
                    dataGridView1.Visible = false;
                }
            }
        }

        DataTable dt = new DataTable();

        private void Sales_Load(object sender, EventArgs e)
        {
            CustomerGrid();
            BindMobiles();

            dt.Columns.Add("Mobile ID", typeof(int));
            dt.Columns.Add("Mobile Name", typeof(string));
            dt.Columns.Add("Model", typeof(string));
            dt.Columns.Add("IMEI", typeof(string));
            dt.Columns.Add("Purchase Rate", typeof(double));
            dt.Columns.Add("Sale Rate", typeof(double));
            dt.Columns.Add("Quantity", typeof(double));
            dt.Columns.Add("Installment %", typeof(double));
            dt.Columns.Add("Amount", typeof(double));

            dataGridView3.DataSource = dt;

            FetchId();
        }

        public void CustomerGrid()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from tbl_Customers";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            CustomerIdTXT.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Cnametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Phonetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CnicTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            previousbalTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dataGridView1.Visible = false;
        }

        public void BindMobiles()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from tbl_Mobiles";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        public void saveBill()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "insert into tbl_Sales values (@salesID, @customerID, @salesDate, @netAmount, @cash, @paymentMethod, @salesType)";
            sql.Open();
            SqlCommand cmd = new SqlCommand(qry, sql);
            cmd.Parameters.AddWithValue("@salesID", salesIDTxt.Text);
            cmd.Parameters.AddWithValue("@customerID", CustomerIdTXT.Text);
            cmd.Parameters.AddWithValue("@salesDate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@netAmount", totalTxt.Text);
            cmd.Parameters.AddWithValue("@cash", cashTxt.Text);
            cmd.Parameters.AddWithValue("@paymentMethod", paymentMethodCmb.Text);
            cmd.Parameters.AddWithValue("@salesType", salesTypeCmb.Text);

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                String qry1 = "insert into tbl_SalesDetails values (@salesID, @mobileID, @purchaseRate, @saleRate, @qty, @installment)";

                SqlCommand cmd1 = new SqlCommand(qry1, sql);
                cmd1.Parameters.AddWithValue("@salesID", salesIDTxt.Text);
                cmd1.Parameters.AddWithValue("@mobileID", dataGridView3.Rows[i].Cells["Mobile ID"].Value.ToString());
                cmd1.Parameters.AddWithValue("@purchaseRate", dataGridView3.Rows[i].Cells["Purchase Rate"].Value.ToString());
                cmd1.Parameters.AddWithValue("@saleRate", dataGridView3.Rows[i].Cells["Sale Rate"].Value.ToString());
                cmd1.Parameters.AddWithValue("@qty", dataGridView3.Rows[i].Cells["Quantity"].Value.ToString());
                cmd1.Parameters.AddWithValue("@installment", dataGridView3.Rows[i].Cells["Installment %"].Value.ToString());

                int aa = cmd1.ExecuteNonQuery();
            }

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("failed");
            }
        }


        public void netAmount()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView3.Rows[i].Cells["Amount"].Value.ToString());

            }

            totalTxt.Text = sum.ToString();
        }

        private void textBox9_KeyUp(object sender, KeyEventArgs e)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Selected = true;
            MobileIdtxt.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            MobileNameTxt.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            Modeltxt.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            IEMitxt.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            purchaseRatetxt.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            Ratetxt.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            stockTxt.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            dataGridView2.Visible = false;
        }

        private void QuantityTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double rate = Convert.ToDouble(Ratetxt.Text);
                double qty = Convert.ToDouble(QuantityTxt.Text);
                double amount = rate * qty;
                amountTxt.Text = amount.ToString();
                amountTxt.Focus();
            }
        }

        private void amountTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dt.Rows.Add(MobileIdtxt.Text, MobileNameTxt.Text, Modeltxt.Text, IEMitxt.Text, purchaseRatetxt.Text, Ratetxt.Text, QuantityTxt.Text, installmentTxt.Text, amountTxt.Text);
                netAmount();
            }
        }

        public void FetchId()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "selecT count(salesID)+1 as id from tbl_Sales";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            salesIDTxt.Text = dt.Rows[0][0].ToString();
        }

        private void installmentTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (installmentTxt.Text != "0")
                {
                    double installment = Convert.ToDouble(installmentTxt.Text);
                    double amount = Convert.ToDouble(Ratetxt.Text) * Convert.ToDouble(QuantityTxt.Text);
                    double percentage = installment / 100 * amount;

                    double final = Convert.ToDouble(amountTxt.Text) + percentage;
                    amountTxt.Text = final.ToString();
                }
                else
                {
                    double amount = Convert.ToDouble(Ratetxt.Text) * Convert.ToDouble(QuantityTxt.Text);
                    amountTxt.Text = amount.ToString();
                   
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveBill();
        }

        private void installmentTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
