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
    public partial class BT3 : Form
    {
        //thực hiện trong file
        FileStream f;
        StreamReader rd;//đọc
        private StreamWriter rw;// viết
        List<MONHOC> ls = new List<MONHOC>();
        
        public BT3()
        {
            InitializeComponent();
        }

        private void BT3_Load(object sender, EventArgs e)
        {
            f = new FileStream("F:\\data.txt", FileMode.Open);
            rd = new StreamReader(f);
            //đọc từ file vào list
            while (!rd.EndOfStream)
            {
                string ID = rd.ReadLine();
                string NAME = rd.ReadLine();
                int STC = int.Parse(rd.ReadLine());

                MONHOC mh = new MONHOC(ID, NAME, STC);
                ls.Add(mh);
            }
            monhoc.DataSource = ls; //cập nhật lại nguồn
            txb1.Text = "";//cách 1
            txb2.Clear();//cách 2
            num1.Value = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monhoc_SelectionChanged(object sender, EventArgs e)
        {
            txb1.Text = monhoc.CurrentRow.Cells[0].Value.ToString();
            txb2.Text = monhoc.CurrentRow.Cells[1].Value.ToString();
            num1.Value = decimal.Parse(monhoc.CurrentRow.Cells[2].Value.ToString());
        }

        private void them_Click(object sender, EventArgs e)
        {
            rw = new StreamWriter(f);
            MONHOC mh = new MONHOC(txb1.Text, txb2.Text, int.Parse(num1.Value.ToString()));
            ls.Add(mh);
            monhoc.DataSource = null;
            monhoc.DataSource = ls;
        }

        private void sua_Click(object sender, EventArgs e)
        {
            rw = new StreamWriter(f);
            foreach (MONHOC m in ls)
                if (m.ID1.CompareTo(txb1.Text) == 0)//so sánh mã của Môn Học với mã của datagv, nếu bằng nhau thì
                {
                    m.ID1 = txb1.Text;
                    m.STC1 = int.Parse(num1.Value.ToString());
                }
            monhoc.DataSource = null;
            monhoc.DataSource = ls;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            rw = new StreamWriter(f);
            int i;
            for (i = 0; i < ls.Count; i++)
                if (ls[i].ID1.CompareTo(txb1.Text) == 0)
                    break;
            if (i < ls.Count)
                ls.RemoveAt(i);
            monhoc.DataSource = null;
            monhoc.DataSource = ls;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
