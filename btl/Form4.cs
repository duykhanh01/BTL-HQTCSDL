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
    public partial class Form4 : Form
    {
        string link_H = @"Data Source=WIND\MSSQLSERVER01;Initial Catalog=shoponline;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
            

        }
        SqlDataAdapter daTab;
        DataTable dTable;
        private void btHTSHIP_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection(link_H);
            conn.Open();
            daTab = new SqlDataAdapter("Select * From membership", conn);
            dTable = new DataTable();
            daTab.Fill(dTable);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dTable;
            db_member_ship.DataSource = bSource;
        }

        private void btnXoaShip_Click(object sender, EventArgs e)
        {
            int i = db_member_ship.CurrentRow.Index;
            db_member_ship.Rows.RemoveAt(i);
            
            SqlConnection conn = new SqlConnection(link_H);
            String sql = "delete from membership where ship_id = '" + mem_id+"'";
            tb1_test.Text = sql;
            SqlCommand com = new SqlCommand(sql, conn);
            com.Connection.Open();
            com.ExecuteNonQuery();
            conn.Close();  
        }
        string mem_id = "";

        private void get_id_member_ship(object sender, DataGridViewCellEventArgs e)
        {
            int i = db_member_ship.CurrentRow.Index;
            mem_id = db_member_ship.Rows[i].Cells[0].Value.ToString();
            tbtest.Text = i.ToString();
            tb1_test.Text = mem_id;
        }

        private void getid(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
