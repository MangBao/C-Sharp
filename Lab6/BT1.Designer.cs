namespace Lab6
{
    partial class BT1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.a1 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.TextBox();
            this.cong = new System.Windows.Forms.RadioButton();
            this.nhan = new System.Windows.Forms.RadioButton();
            this.chia = new System.Windows.Forms.RadioButton();
            this.tru = new System.Windows.Forms.RadioButton();
            this.exit = new System.Windows.Forms.Button();
            this.tinh = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.a.Location = new System.Drawing.Point(39, 38);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(111, 26);
            this.a.TabIndex = 0;
            this.a.Text = "Số hạng 1";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b.Location = new System.Drawing.Point(39, 116);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(111, 26);
            this.b.TabIndex = 1;
            this.b.Text = "Số hạng 2";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.c.Location = new System.Drawing.Point(39, 193);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(64, 26);
            this.c.TabIndex = 2;
            this.c.Text = "Tổng";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.tru);
            this.gb1.Controls.Add(this.chia);
            this.gb1.Controls.Add(this.nhan);
            this.gb1.Controls.Add(this.cong);
            this.gb1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(448, 42);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(165, 210);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            this.gb1.Text = "Phép toán";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(214, 42);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(140, 22);
            this.a1.TabIndex = 0;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(214, 197);
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Size = new System.Drawing.Size(140, 22);
            this.c1.TabIndex = 4;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(214, 120);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(140, 22);
            this.b1.TabIndex = 5;
            // 
            // cong
            // 
            this.cong.AutoSize = true;
            this.cong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cong.Location = new System.Drawing.Point(29, 33);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(84, 31);
            this.cong.TabIndex = 6;
            this.cong.TabStop = true;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            // 
            // nhan
            // 
            this.nhan.AutoSize = true;
            this.nhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nhan.Location = new System.Drawing.Point(29, 107);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(85, 31);
            this.nhan.TabIndex = 7;
            this.nhan.TabStop = true;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            // 
            // chia
            // 
            this.chia.AutoSize = true;
            this.chia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chia.Location = new System.Drawing.Point(29, 144);
            this.chia.Name = "chia";
            this.chia.Size = new System.Drawing.Size(78, 31);
            this.chia.TabIndex = 8;
            this.chia.TabStop = true;
            this.chia.Text = "Chia";
            this.chia.UseVisualStyleBackColor = true;
            // 
            // tru
            // 
            this.tru.AutoSize = true;
            this.tru.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tru.Location = new System.Drawing.Point(29, 70);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(67, 31);
            this.tru.TabIndex = 9;
            this.tru.TabStop = true;
            this.tru.Text = "Trừ";
            this.tru.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.exit.Location = new System.Drawing.Point(77, 299);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 47);
            this.exit.TabIndex = 6;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tinh
            // 
            this.tinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tinh.Location = new System.Drawing.Point(324, 299);
            this.tinh.Name = "tinh";
            this.tinh.Size = new System.Drawing.Size(87, 47);
            this.tinh.TabIndex = 7;
            this.tinh.Text = "Tính";
            this.tinh.UseVisualStyleBackColor = true;
            this.tinh.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 436);
            this.Controls.Add(this.tinh);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Máy tính Mini";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.TextBox b1;
        private System.Windows.Forms.RadioButton cong;
        private System.Windows.Forms.RadioButton tru;
        private System.Windows.Forms.RadioButton chia;
        private System.Windows.Forms.RadioButton nhan;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button tinh;
    }
}

