using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinoRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x_dino, y_dino;
        int diem = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            cloud1.Size = new Size(70, 47);
            cloud1.Location = new Point(77, 103);
            //======================================
            cloud2.Size = new Size(70, 47);
            cloud2.Location = new Point(286, 152);
            //======================================
            cloud3.Size = new Size(70, 47);
            cloud3.Location = new Point(511, 103);
            //======================================
            cloud4.Size = new Size(70, 47);
            cloud4.Location = new Point(767, 152);
            //======================================
            sun.Size = new Size(98, 97);
            sun.Location = new Point(790, 75);
            //======================================
            nen.Size = new Size(1000, this.Height - 40);
            x_dino = 12;
            y_dino = 270;
            dino.Size = new Size(100, 96);
            dino.Location = new Point(x_dino, y_dino);
            //======================================
            tree1.Size = new Size(60, 95);
            tree1.Location = new Point(437, 270);
            //======================================
            tree2.Size = new Size(103, 95);
            tree2.Location = new Point(900, 270);

            timer1.Interval = 60;
            timer2.Interval = 100;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cloud1.Left >= 0)
            {
                
                cloud1.Left -= 5;
            }
            else
            {
                cloud1.Left = 1000;
            }
            if (cloud2.Left >= 0)
            {
                cloud2.Left -= 5;
            }
            else
            {
                cloud2.Left = 1000;
            }
            if (cloud3.Left >= 0)
            {
                cloud3.Left -= 5;
            }
            else
            {
                cloud3.Left = 1000;
            }
            if (cloud4.Left >= 0)
            {
                cloud4.Left -= 5;
            }
            else
            {
                cloud4.Left = 1000;
            }
            if (tree1.Left >= 0)
            {
                tree1.Left -= 20;
            }
            else
            {
                tree1.Left = 1000;
            }
            if (tree2.Left >= 0)
            {
                tree2.Left -= 20;
            }
            else
            {
                tree2.Left = 1000;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(dino.Top <=250)
            {
                dino.Top += 20 ;
                /*if()
                dino.Location = new Point(x_dino, y_dino);*/
                if(dino.Top)
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                dino.Top -= 200;
            }
        }
    }
}
