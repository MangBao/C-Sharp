namespace Lab6
{
    partial class BT3
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
            this.INFOR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.monhoc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // INFOR
            // 
            this.INFOR.AutoSize = true;
            this.INFOR.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.INFOR.ForeColor = System.Drawing.Color.Fuchsia;
            this.INFOR.Location = new System.Drawing.Point(49, 38);
            this.INFOR.Name = "INFOR";
            this.INFOR.Size = new System.Drawing.Size(335, 34);
            this.INFOR.TabIndex = 1;
            this.INFOR.Text = "THÔNG TIN SINH VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(572, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH MÔN HỌC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã môn học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(40, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(40, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số tín chỉ:";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(197, 116);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(170, 22);
            this.txb1.TabIndex = 7;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(197, 197);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(170, 22);
            this.txb2.TabIndex = 9;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(197, 279);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(170, 22);
            this.num1.TabIndex = 10;
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(113, 411);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(115, 53);
            this.them.TabIndex = 11;
            this.them.Text = "Thêm ";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.Location = new System.Drawing.Point(552, 411);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(115, 53);
            this.xoa.TabIndex = 12;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua.Location = new System.Drawing.Point(333, 411);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(115, 53);
            this.sua.TabIndex = 13;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.close.Location = new System.Drawing.Point(765, 411);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(115, 53);
            this.close.TabIndex = 14;
            this.close.Text = "Đóng";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // monhoc
            // 
            this.monhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monhoc.Location = new System.Drawing.Point(578, 116);
            this.monhoc.Name = "monhoc";
            this.monhoc.RowHeadersWidth = 51;
            this.monhoc.RowTemplate.Height = 24;
            this.monhoc.Size = new System.Drawing.Size(334, 224);
            this.monhoc.TabIndex = 15;
            this.monhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.monhoc.SelectionChanged += new System.EventHandler(this.monhoc_SelectionChanged);
            // 
            // BT3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 611);
            this.Controls.Add(this.monhoc);
            this.Controls.Add(this.close);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.INFOR);
            this.Name = "BT3";
            this.Text = "BT3";
            this.Load += new System.EventHandler(this.BT3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label INFOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView monhoc;
    }
}