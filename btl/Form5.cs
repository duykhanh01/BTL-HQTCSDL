using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace btl
{

    public partial class orderDetail : Form
    {
        string link_H = @"Data Source=WIND\MSSQLSERVER01;Initial Catalog=shoponline;Integrated Security=True";
        public orderDetail()
        {
            InitializeComponent();
        }
        public string or_id;
        SqlDataAdapter daTab;
        DataTable dTable;
        private void orderDetail_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(link_H);
            //conn.Open();
            //String sql = "Select * from ordersDetail where or_id = '" + or_id + "'";
            //SqlCommand com = new SqlCommand(sql, conn);
            //com.CommandType = CommandType.Text;
            //SqlDataAdapter da1 = new SqlDataAdapter(com);
            //DataTable dt1 = new DataTable();
            //da1.Fill(dt1);
            //conn.Close();
            //dbOrderDetail.DataSource = dt1;
            SqlConnection conn = new SqlConnection(link_H);
            conn.Open();
            daTab = new SqlDataAdapter("Select * from orderDetail where or_id = '" + or_id + "'", conn);
            dTable = new DataTable();
            daTab.Fill(dTable);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dTable;
            dbOrderDetail.DataSource = bSource;
           
        }

        private void dbOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBackHome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
