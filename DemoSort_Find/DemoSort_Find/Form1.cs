using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DemoSort_Find
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            var input = txtInput.Text;
            var sorted = from sp in input.Split(',')
                         let reg = Regex.Match(sp, @"(?<num>[0-9]+)(?<char>[a-z]*)", RegexOptions.IgnoreCase | RegexOptions.Compiled)
                         let number = int.Parse(reg.Groups["num"].ToString())
                         orderby reg.Groups["char"].ToString() ascending // sort first by letter
                         orderby number ascending // then by number
                         select sp;
            var result = string.Join(",", sorted);

            txtInput.Text = result.ToString();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            var input = txtInput.Text;
            string[] result = input.Split(',');
            string x = textBox1.Text;

            int i;
            for (i = 0; i < result.Length; i++) { }
                if (result[i] == x)
                    textBox1.Text = i.ToString();

            textBox1.Text = i.ToString();
        }
    }
}
