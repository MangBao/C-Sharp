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

        public void HienThi1()
        {
            string sqlSelect = "select a.TenSach, b.TenTL from Sach a, TheLoai b where a.MaTL = b.MaTL and b.TenTL = N'" + txtFind.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv.DataSource = dt;
        }

        public void HienThi2()
        {
            string sqlSelect = "select a.TenSach, b.GiabanS from Sach a, ChiTietHDS b where a.MaSach = b.MaSach order by b.GiaBanS";
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
            string ms = dgv.Rows[i].Cells[0].Value.ToString();
            string ts = dgv.Rows[i].Cells[1].Value.ToString();
            string ttg = dgv.Rows[i].Cells[2].Value.ToString();
            string nxb = dgv.Rows[i].Cells[3].Value.ToString();
            string mtl = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            string sqlSort = "select a.TenSach, b.GiabanS from Sach a, ChiTietHDS b where a.MaSach = b.MaSach order by b.GiaBanS";
            SqlCommand cmd = new SqlCommand(sqlSort, con);
            cmd.ExecuteNonQuery();
            HienThi2();
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            //string sqlFind = "select a.TenSach from Sach a, TheLoai b where a.MaTL = b.MaTL and b.TenTL = N'" + txtFind.Text + "'";
            string sqlFind = "exec pr_TIM_KIEM N'" + txtFind.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlFind, con);
            cmd.ExecuteNonQuery();
            HienThi1();
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        
    }
}
