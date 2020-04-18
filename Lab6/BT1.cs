using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = float.Parse(a1.Text);
            float b = float.Parse(b1.Text);
            float c = 0;
            if (cong.Checked)
            {
                c = a + b;
                c1.Text = "Tổng";
            }
            if (tru.Checked)
            {
                c = a - b;
                c1.Text = "Hiệu";
            }
            if (nhan.Checked)
            {
                c = a * b;
                c1.Text = "Tích";
            }
            if (chia.Checked)
            {
                c = a / b;
                c1.Text = "Thương";
            }
            c1.Text = c.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
