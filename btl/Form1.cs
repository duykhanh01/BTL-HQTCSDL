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
using System.Data.SqlClient;

namespace btl
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        string link_k = @"Data Source=DESKTOP-R3U1CE5\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=ShopOnline";
=======
        string link_H = @"Data Source=WIND\MSSQLSERVER01;Initial Catalog=shoponline;Integrated Security=True";
>>>>>>> 348f0777b9b2f820a46b8d375eee8faef6f62feb
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
<<<<<<< HEAD

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
=======
       
        private void btShowOrder_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(link_H);
            conn.Open();
            String sql = "Select * from orders";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            dbOrder.DataSource = dt;
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            orderDetail od = new orderDetail();
            od.or_id = id_order;
            if(od.or_id !="")
            {
                od.Show();
                this.Hide();
            }    
            
        }

        string id_order = "";
        private void getIDOrder(object sender, DataGridViewCellEventArgs e)
        {
            int i = dbOrder.CurrentRow.Index;
            check = i;
            id_order = dbOrder.Rows[i].Cells[0].Value.ToString();
            cbTrangThai.Text = dbOrder.Rows[i].Cells[9].Value.ToString();

        }

        private void qlhoadon_Click(object sender, EventArgs e)
        {

        }
        int check;
        private void btXoaHD_Click(object sender, EventArgs e)
        {
            int i = dbOrder.CurrentRow.Index;
            
            dbOrder.Rows.RemoveAt(i);

            SqlConnection conn = new SqlConnection(link_H);
            String sql = "delete from orders where or_id = '" + id_order + "'";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Connection.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }

        private void btXuatHD_Click(object sender, EventArgs e)
        {

        }

        private void luuTT_Click(object sender, EventArgs e)
        {

            if (check >= 0)
            {
                string stt = cbTrangThai.Text;
                SqlConnection conn = new SqlConnection(link_H);
                String sql = "update orders set or_status = N'" + stt + "' where or_id = '" + id_order + "'";
                SqlCommand com = new SqlCommand(sql, conn);
                com.Connection.Open();
                com.ExecuteNonQuery();
                conn.Close();
                dbOrder.Rows[check].Cells[9].Value = cbTrangThai.Text;
            }
        }

        private void dbOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

>>>>>>> 348f0777b9b2f820a46b8d375eee8faef6f62feb
        }
    }
}
