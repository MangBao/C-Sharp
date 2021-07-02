namespace QLBanHang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_mtl = new System.Windows.Forms.TextBox();
            this.tb_ts = new System.Windows.Forms.TextBox();
            this.tb_ttg = new System.Windows.Forms.TextBox();
            this.tb_ms = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_quit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btSort = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.dtp_nxb = new System.Windows.Forms.DateTimePicker();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.dgv);
            this.groupBox3.Location = new System.Drawing.Point(69, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(873, 324);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng thông tin";
            // 
            // dgv
            // 
            this.dgv.AllowDrop = true;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv.Location = new System.Drawing.Point(86, 33);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(685, 285);
            this.dgv.StandardTab = true;
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtp_nxb);
            this.groupBox4.Controls.Add(this.tb_mtl);
            this.groupBox4.Controls.Add(this.tb_ts);
            this.groupBox4.Controls.Add(this.bt_quit);
            this.groupBox4.Controls.Add(this.tb_ttg);
            this.groupBox4.Controls.Add(this.tb_ms);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(31, 368);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(555, 294);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin chi tiết";
            // 
            // tb_mtl
            // 
            this.tb_mtl.Location = new System.Drawing.Point(143, 172);
            this.tb_mtl.Name = "tb_mtl";
            this.tb_mtl.Size = new System.Drawing.Size(164, 34);
            this.tb_mtl.TabIndex = 9;
            // 
            // tb_ts
            // 
            this.tb_ts.Location = new System.Drawing.Point(143, 107);
            this.tb_ts.Name = "tb_ts";
            this.tb_ts.Size = new System.Drawing.Size(164, 34);
            this.tb_ts.TabIndex = 7;
            // 
            // tb_ttg
            // 
            this.tb_ttg.Location = new System.Drawing.Point(143, 242);
            this.tb_ttg.Name = "tb_ttg";
            this.tb_ttg.Size = new System.Drawing.Size(164, 34);
            this.tb_ttg.TabIndex = 6;
            // 
            // tb_ms
            // 
            this.tb_ms.Location = new System.Drawing.Point(143, 37);
            this.tb_ms.Name = "tb_ms";
            this.tb_ms.Size = new System.Drawing.Size(164, 34);
            this.tb_ms.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 27);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mã thể loại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 27);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ngày xuất bản:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 27);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên tác giả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên Sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sách:";
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(36, 59);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(114, 61);
            this.bt_insert.TabIndex = 2;
            this.bt_insert.Text = "Thêm";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(371, 185);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(114, 61);
            this.bt_quit.TabIndex = 5;
            this.bt_quit.Text = "Thoát";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtFind);
            this.groupBox5.Controls.Add(this.btFind);
            this.groupBox5.Controls.Add(this.btSort);
            this.groupBox5.Controls.Add(this.bt_insert);
            this.groupBox5.Location = new System.Drawing.Point(625, 368);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(362, 294);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thao tác";
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(203, 59);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(114, 61);
            this.btSort.TabIndex = 6;
            this.btSort.Text = "Sắp xếp";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(72, 208);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(201, 48);
            this.btFind.TabIndex = 7;
            this.btFind.Text = "Tìm kiếm tên TL";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // dtp_nxb
            // 
            this.dtp_nxb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nxb.Location = new System.Drawing.Point(347, 89);
            this.dtp_nxb.Name = "dtp_nxb";
            this.dtp_nxb.Size = new System.Drawing.Size(162, 34);
            this.dtp_nxb.TabIndex = 11;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(99, 168);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(157, 34);
            this.txtFind.TabIndex = 8;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 683);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sách";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_mtl;
        private System.Windows.Forms.TextBox tb_ts;
        private System.Windows.Forms.TextBox tb_ttg;
        private System.Windows.Forms.TextBox tb_ms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.DateTimePicker dtp_nxb;
        private System.Windows.Forms.TextBox txtFind;
    }
}

