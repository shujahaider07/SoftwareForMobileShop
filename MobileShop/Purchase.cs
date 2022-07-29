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

namespace MobileShop
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void Purchase_Load(object sender, EventArgs e)
        {
            SupplierGrid();
            FetchId();
        }

        public void SupplierGrid()
        {


            SqlConnection sql = new SqlConnection(cs);
            String qry = "select * from tbl_suppliers";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void Cnametxt_KeyUp(object sender, KeyEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;

            SupplierId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            SupplierNametxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Phonetxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            AddressTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            previousbalTxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dataGridView1.Visible = false;


        }
   
        public void FetchId()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "select count(salesID)+1 from tbl_Sales";
            SqlDataAdapter da = new SqlDataAdapter(qry,sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            salesIdtxt.Text = dt.Rows[0][0].ToString();

                 
        }
    
    }
}
