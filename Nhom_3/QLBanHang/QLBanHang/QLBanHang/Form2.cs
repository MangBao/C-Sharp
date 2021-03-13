using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Sach.Hide();
            KH.Hide();
            HD.Hide();
            PN.Hide();
        }

        private void bt_SignIn_Click(object sender, EventArgs e)
        {
            string str1 = "admin";
            string str2 = "123456";
            if ((tb_user.Text == str1) && tb_pass.Text == str2)
            {
                user.Hide();
                pw.Hide();
                bt_SignIn.Hide();
                tb_user.Hide();
                tb_pass.Hide();
                Sach.Show();
                KH.Show();
                HD.Show();
                PN.Show();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!");
        }

        private void Sach_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void KH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại chưa cập nhật khách hàng");
        }

        private void HD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại chưa cập nhật hóa đơn");
        }

        private void PN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiên bản hiện tại chưa cập nhật phiếu nhập");
        }
    }
}
