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
        string link_H = @"Data Source=WIND\MSSQLSERVER01;Initial Catalog=shoponline;Integrated Security=True";
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

        }
    }
}
