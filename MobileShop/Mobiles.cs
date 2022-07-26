using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

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
            String qry = "insert into tbl_mobiles values (@mobilename , @mobileiemi, @mobilerate , @mobileModel ,@investorId)";
            SqlCommand cmd = new SqlCommand(qry,sql);
            cmd.Parameters.AddWithValue("@mobilename", mobilenametxt.Text);
            cmd.Parameters.AddWithValue("@mobileiemi", iemitxt.Text);
            cmd.Parameters.AddWithValue("@mobilerate", mobpricetxt.Text);
            cmd.Parameters.AddWithValue("@mobileModel", ModelTxt.Text);
            cmd.Parameters.AddWithValue("@investorId", investornameCmb.SelectedItem.ToString());
            
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
            SqlDataAdapter da = new SqlDataAdapter(qry,sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            mobileidtxt.Text = dt.Rows[0][0].ToString();


        }

        private void Mobiles_Load(object sender, EventArgs e)
        {
            FetchMobileId();
            SqlConnection sql = new SqlConnection(cs);
            sql.Open();
            string qry = "select investorID, investorName from tbl_Investors";
            SqlCommand cmd = new SqlCommand(qry, sql);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                investornameCmb.Items.Add(reader["investorID"].ToString() + "," + reader["investorName"].ToString());
            }
            sql.Close();
        }

        private void investornameCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
         string insID = investornameCmb.SelectedItem.ToString().Substring(0, 1);  
        }

        private void mobpricetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
