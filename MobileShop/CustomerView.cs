﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }


        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private void CustomerView_Load(object sender, EventArgs e)
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
            string qry = "select * from  tbl_Customers where CustomerName like '%" + searchTxt.Text + "%' ";    
            SqlDataAdapter da = new SqlDataAdapter(qry, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
