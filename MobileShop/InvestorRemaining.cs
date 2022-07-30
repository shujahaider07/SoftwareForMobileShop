using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class InvestorRemaining : Form
    {
        public InvestorRemaining()
        {
            InitializeComponent();
        }

        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void InvestorRemaining_Load(object sender, EventArgs e)
        {
            bindGridView();
        }

        public void bindGridView()
        {
            SqlConnection sql = new SqlConnection(cs);
            String qry = "exec sp_InvestorRemaining";
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
