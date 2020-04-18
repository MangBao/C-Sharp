using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab6
{
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void open_Click(object sender, EventArgs e)
        {
            anh1.Image = Image.FromFile("F:\\baobao.jpeg");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
