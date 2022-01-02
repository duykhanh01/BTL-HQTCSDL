using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    public partial class Form1 : Form
    {
        string link_k = @"Data Source=DESKTOP-R3U1CE5\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=ShopOnline";
        public Form1()
        {
            InitializeComponent();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHienThiKH_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(link_k);
            con.Open();
            String sql = "Select * from users";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            bangKH.DataSource = dt;
        }
    }
}
