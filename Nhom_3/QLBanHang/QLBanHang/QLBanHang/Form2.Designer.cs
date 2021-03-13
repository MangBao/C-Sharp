namespace QLBanHang
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.user = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.bt_SignIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Sach = new System.Windows.Forms.Button();
            this.KH = new System.Windows.Forms.Button();
            this.HD = new System.Windows.Forms.Button();
            this.PN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.SystemColors.ControlLight;
            this.user.Location = new System.Drawing.Point(165, 134);
            this.user.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(160, 27);
            this.user.TabIndex = 0;
            this.user.Text = "Tên đăng nhập:";
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pw.Location = new System.Drawing.Point(215, 173);
            this.pw.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(110, 27);
            this.pw.TabIndex = 1;
            this.pw.Text = "Mật khẩu:";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(335, 170);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(5);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(166, 34);
            this.tb_pass.TabIndex = 3;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(335, 131);
            this.tb_user.Margin = new System.Windows.Forms.Padding(5);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(166, 34);
            this.tb_user.TabIndex = 4;
            // 
            // bt_SignIn
            // 
            this.bt_SignIn.BackColor = System.Drawing.Color.MistyRose;
            this.bt_SignIn.Location = new System.Drawing.Point(309, 212);
            this.bt_SignIn.Name = "bt_SignIn";
            this.bt_SignIn.Size = new System.Drawing.Size(134, 45);
            this.bt_SignIn.TabIndex = 5;
            this.bt_SignIn.Text = "Đăng nhập";
            this.bt_SignIn.UseVisualStyleBackColor = false;
            this.bt_SignIn.Click += new System.EventHandler(this.bt_SignIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(480, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quản lý bán sách Nhã Trang";
            // 
            // Sach
            // 
            this.Sach.Location = new System.Drawing.Point(33, 134);
            this.Sach.Name = "Sach";
            this.Sach.Size = new System.Drawing.Size(124, 53);
            this.Sach.TabIndex = 7;
            this.Sach.Text = "Sách";
            this.Sach.UseVisualStyleBackColor = true;
            this.Sach.Click += new System.EventHandler(this.Sach_Click);
            // 
            // KH
            // 
            this.KH.Location = new System.Drawing.Point(168, 134);
            this.KH.Name = "KH";
            this.KH.Size = new System.Drawing.Size(135, 53);
            this.KH.TabIndex = 8;
            this.KH.Text = "Khách hàng";
            this.KH.UseVisualStyleBackColor = true;
            this.KH.Click += new System.EventHandler(this.KH_Click);
            // 
            // HD
            // 
            this.HD.Location = new System.Drawing.Point(318, 134);
            this.HD.Name = "HD";
            this.HD.Size = new System.Drawing.Size(115, 53);
            this.HD.TabIndex = 9;
            this.HD.Text = "Hóa đơn";
            this.HD.UseVisualStyleBackColor = true;
            this.HD.Click += new System.EventHandler(this.HD_Click);
            // 
            // PN
            // 
            this.PN.Location = new System.Drawing.Point(449, 134);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(144, 53);
            this.PN.TabIndex = 10;
            this.PN.Text = "Phiếu nhập";
            this.PN.UseVisualStyleBackColor = true;
            this.PN.Click += new System.EventHandler(this.PN_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(622, 414);
            this.Controls.Add(this.PN);
            this.Controls.Add(this.HD);
            this.Controls.Add(this.KH);
            this.Controls.Add(this.Sach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_SignIn);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.user);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button bt_SignIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sach;
        private System.Windows.Forms.Button KH;
        private System.Windows.Forms.Button HD;
        private System.Windows.Forms.Button PN;
    }
}