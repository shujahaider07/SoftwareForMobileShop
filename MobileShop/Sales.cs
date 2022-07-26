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

        private void Sales_Load(object sender, EventArgs e)
        {
            CustomerGrid();
            BindMobiles();

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
            Ratetxt.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            Investortxt.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();




        }
    }
}
