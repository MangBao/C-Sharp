using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Configuration;

namespace QLBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Open();
            HienThi();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
        }

        public void HienThi()
        {
            string sqlSelect = "select * from Sach";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv.DataSource = dt;
        }       
        
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tb_ms.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_ts.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_ttg.Text = dgv.Rows[i].Cells[2].Value.ToString();
            dtp_nxb.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_mtl.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            string sqlInsert = "insert into Sach values('" + tb_ms.Text + "','" + tb_ts.Text + "','" + tb_ttg.Text + "','" + dtp_nxb.Text + "','" + tb_mtl.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlInsert, con);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "update Sach set TenSach = '" + tb_ts.Text + "', TenTG =  '" + tb_ttg.Text + "', NgayXB = '" + dtp_nxb.Text + "', MaTL = '" + tb_mtl.Text + "' where MaSach = '" + tb_ms.Text + "' ";
            SqlCommand cmd = new SqlCommand(sqlUpdate, con);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            string sqlFint = "exec pr_XOA_SACH '" + tb_ms.Text +"'";
            SqlCommand cmd = new SqlCommand(sqlFint, con);
            cmd.ExecuteNonQuery();
            HienThi();
        }
    
        private void bt_quit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void dtp_nxb_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
