namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ongtren1 = new System.Windows.Forms.PictureBox();
            this.ongduoi1 = new System.Windows.Forms.PictureBox();
            this.ongtren2 = new System.Windows.Forms.PictureBox();
            this.ongduoi2 = new System.Windows.Forms.PictureBox();
            this.chim = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblDiemso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chim)).BeginInit();
            this.SuspendLayout();
            // 
            // ongtren1
            // 
            this.ongtren1.Image = ((System.Drawing.Image)(resources.GetObject("ongtren1.Image")));
            this.ongtren1.Location = new System.Drawing.Point(68, -851);
            this.ongtren1.Name = "ongtren1";
            this.ongtren1.Size = new System.Drawing.Size(273, 1004);
            this.ongtren1.TabIndex = 0;
            this.ongtren1.TabStop = false;
            this.ongtren1.Click += new System.EventHandler(this.ongtren1_Click);
            // 
            // ongduoi1
            // 
            this.ongduoi1.Image = ((System.Drawing.Image)(resources.GetObject("ongduoi1.Image")));
            this.ongduoi1.Location = new System.Drawing.Point(60, 270);
            this.ongduoi1.Name = "ongduoi1";
            this.ongduoi1.Size = new System.Drawing.Size(281, 1000);
            this.ongduoi1.TabIndex = 1;
            this.ongduoi1.TabStop = false;
            // 
            // ongtren2
            // 
            this.ongtren2.Image = ((System.Drawing.Image)(resources.GetObject("ongtren2.Image")));
            this.ongtren2.Location = new System.Drawing.Point(422, -844);
            this.ongtren2.Name = "ongtren2";
            this.ongtren2.Size = new System.Drawing.Size(262, 997);
            this.ongtren2.TabIndex = 2;
            this.ongtren2.TabStop = false;
            // 
            // ongduoi2
            // 
            this.ongduoi2.Image = ((System.Drawing.Image)(resources.GetObject("ongduoi2.Image")));
            this.ongduoi2.Location = new System.Drawing.Point(403, 270);
            this.ongduoi2.Name = "ongduoi2";
            this.ongduoi2.Size = new System.Drawing.Size(281, 1000);
            this.ongduoi2.TabIndex = 3;
            this.ongduoi2.TabStop = false;
            // 
            // chim
            // 
            this.chim.Image = ((System.Drawing.Image)(resources.GetObject("chim.Image")));
            this.chim.Location = new System.Drawing.Point(12, 163);
            this.chim.Name = "chim";
            this.chim.Size = new System.Drawing.Size(129, 101);
            this.chim.TabIndex = 4;
            this.chim.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblDiemso
            // 
            this.lblDiemso.AutoSize = true;
            this.lblDiemso.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemso.Location = new System.Drawing.Point(3, 388);
            this.lblDiemso.Name = "lblDiemso";
            this.lblDiemso.Size = new System.Drawing.Size(194, 60);
            this.lblDiemso.TabIndex = 5;
            this.lblDiemso.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.lblDiemso);
            this.Controls.Add(this.chim);
            this.Controls.Add(this.ongduoi2);
            this.Controls.Add(this.ongtren2);
            this.Controls.Add(this.ongduoi1);
            this.Controls.Add(this.ongtren1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ongtren1;
        private System.Windows.Forms.PictureBox ongduoi1;
        private System.Windows.Forms.PictureBox ongtren2;
        private System.Windows.Forms.PictureBox ongduoi2;
        private System.Windows.Forms.PictureBox chim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblDiemso;
    }
}

