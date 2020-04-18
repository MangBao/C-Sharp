using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int DCL = 250; // Độ chênh lệch giữa 2 ống
        int x_cap1, x_cap2;//Thay thế cho x_ongtren1, x_ongduoi1 và x_ongtren2, x_duoi2
        int y_ongtren1;
        int y_ongduoi1;
        int y_ongtren2;
        int y_ongduoi2;
        int x_chim, y_chim;
        int diem = 0;
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Start();
                timer2.Start();
            }
            if (e.KeyCode == Keys.Space)
            {               
                y_chim -= 80;// Độ cao mà con chim nhảy khoảng 80.có thể chỉnh lên cao để tạo đô khó game
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // DoubleBuffer => hiệu chỉnh không bị giựt màn hình.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            x_cap1 -= 10;
            x_cap2 -= 10;

            ongtren1.Location = new Point(x_cap1, y_ongtren1);// Set lại vị trí các ống 
            ongduoi1.Location = new Point(x_cap1, y_ongduoi1);
            ongtren2.Location = new Point(x_cap2, y_ongtren2);
            ongduoi2.Location = new Point(x_cap2, y_ongduoi2);
            //Kiểm tra nếu cặp ống 1 mà đi qua khỏi Form thì nó hiện lại phía sau cặp ống 2
            if (x_cap1 + ongtren1.Width <= 0)
            {
                diem++;
                x_cap1 = 800 + ongtren2.Width + 400;// 400 là khoảng cách giữa 2 cặp
                Random rd = new Random();
                y_ongtren1 = rd.Next(-800, -400);
                y_ongduoi1 = (1000 + y_ongtren1) + DCL;
                ongtren1.Location = new Point(x_cap1, y_ongtren1);//Tạo vị trí mới cho ống trên 1 và ống dưới 1
                ongduoi1.Location = new Point(x_cap1, y_ongduoi1);
            }
            //Kiểm tra nếu cặp ống 2 mà đi qua khỏi Form thì nó hiện lại phía sau cặp ống 1
            if (x_cap2 + ongtren2.Width <= 0)
            {
                diem++;
                x_cap2 = 800 + ongtren1.Width + 400;
                Random rd = new Random();
                y_ongtren2 = rd.Next(-800, -400);
                y_ongduoi2 = (1000 + y_ongtren2) + DCL;
                ongtren2.Location = new Point(x_cap2, y_ongtren2);//Tạo vị trí mới cho ống trên 2 và ống dưới 2
                ongduoi2.Location = new Point(x_cap2, y_ongduoi2);
            }
            lbldiem.Text = "Score: " + diem.ToString();//Ghi điểm sau khi qua mỗi ống
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // DoubleBuffer => hiệu chỉnh không bị giựt màn hình.
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            if (y_chim + chim.Height <= this.Height)
            {
                y_chim += 10;
                chim.Location = new Point(x_chim, y_chim);
                //Chỉnh tọa độ của con chim khi chạm cột hoặc chạm đất sẽ thua 
                if (x_chim + chim.Width >= x_cap1 && x_chim + chim.Width <= x_cap1 + ongtren1.Width)
                {
                    if (y_chim <= 1000 + y_ongtren1 || y_chim + chim.Height >= y_ongduoi1)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        MessageBox.Show("Game Over!\n Your Score: " + diem);
                    }
                }

                if (x_chim + chim.Width >= x_cap2 && x_chim + chim.Width <= x_cap1 + ongtren2.Width)
                {
                    if (y_chim <= 1000 + y_ongtren2 || y_chim + chim.Height >= y_ongduoi2)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        MessageBox.Show("Game Over!\n Your Score: " + diem + "\n");
                    }
                }

            }
            else
            {
                timer2.Stop();
                timer1.Stop();
            }
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
                // Đoạn code mở full màn hình*/
                this.FormBorderStyle = FormBorderStyle.None;
                this.Left = 0;
                this.Top = 0;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                //===============================================
            

                x_cap1 = this.Width + 300; //Cách từ trái winform 300

                y_ongtren1 = -700; //Thụt trên winform xuống 300
                ongtren1.Size = new Size(270, 1000);
                ongtren1.Location = new Point(x_cap1, y_ongtren1);

                y_ongduoi1 = (1000 + y_ongtren1) + DCL;// Lấy độ dài của ống 1 là 1000 + phần bị thụt + Độ chênh lệch giữa 2 ống
                ongduoi1.Size = new Size(270, 1000);
                ongduoi1.Location = new Point(x_cap1, y_ongduoi1);
                //===============================================


                x_cap2 = x_cap1 + ongtren1.Width + 500; //Mỗi ống cách nhau 500

                y_ongtren2 = -700; //Thụt trên winform xuống 300
                ongtren2.Size = new Size(270, 1000);
                ongtren2.Location = new Point(x_cap2, y_ongtren2);

                y_ongduoi2 = (1000 + y_ongtren2) + DCL;// Lấy độ dài của ống 1 là 1000 + phần bị thụt + Độ chênh lệch giữa 2 ống
                ongduoi2.Size = new Size(270, 1000);
                ongduoi2.Location = new Point(x_cap2, y_ongduoi2);

                chim.Size = new Size(127, 100);
                x_chim = chim.Location.X;
                y_chim = chim.Location.Y;


                lbldiem.Location = new Point(0, this.Height - 50);// Set vị trí label điểm, this.Height - 50 có nghĩa là lấy chiều cao của form lùi về phần âm 50 là local of điểm
                timer1.Interval = 1; 
                timer2.Interval = 50;
        }
    }
}
