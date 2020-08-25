namespace DinoRun
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
            this.dino = new System.Windows.Forms.PictureBox();
            this.tree1 = new System.Windows.Forms.PictureBox();
            this.tree2 = new System.Windows.Forms.PictureBox();
            this.nen = new System.Windows.Forms.PictureBox();
            this.sun = new System.Windows.Forms.PictureBox();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.cloud3 = new System.Windows.Forms.PictureBox();
            this.cloud4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud4)).BeginInit();
            this.SuspendLayout();
            // 
            // dino
            // 
            this.dino.BackColor = System.Drawing.SystemColors.Control;
            this.dino.Image = ((System.Drawing.Image)(resources.GetObject("dino.Image")));
            this.dino.Location = new System.Drawing.Point(49, 343);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(100, 95);
            this.dino.TabIndex = 0;
            this.dino.TabStop = false;
            this.dino.Click += new System.EventHandler(this.dino_Click);
            // 
            // tree1
            // 
            this.tree1.BackColor = System.Drawing.SystemColors.Control;
            this.tree1.Image = ((System.Drawing.Image)(resources.GetObject("tree1.Image")));
            this.tree1.Location = new System.Drawing.Point(437, 342);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(60, 96);
            this.tree1.TabIndex = 1;
            this.tree1.TabStop = false;
            // 
            // tree2
            // 
            this.tree2.BackColor = System.Drawing.SystemColors.Control;
            this.tree2.Image = ((System.Drawing.Image)(resources.GetObject("tree2.Image")));
            this.tree2.Location = new System.Drawing.Point(767, 345);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(103, 93);
            this.tree2.TabIndex = 2;
            this.tree2.TabStop = false;
            // 
            // nen
            // 
            this.nen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.nen.Location = new System.Drawing.Point(-4, 423);
            this.nen.Name = "nen";
            this.nen.Size = new System.Drawing.Size(1000, 136);
            this.nen.TabIndex = 3;
            this.nen.TabStop = false;
            // 
            // sun
            // 
            this.sun.Image = ((System.Drawing.Image)(resources.GetObject("sun.Image")));
            this.sun.Location = new System.Drawing.Point(790, 75);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(98, 97);
            this.sun.TabIndex = 4;
            this.sun.TabStop = false;
            // 
            // cloud1
            // 
            this.cloud1.Image = ((System.Drawing.Image)(resources.GetObject("cloud1.Image")));
            this.cloud1.Location = new System.Drawing.Point(77, 103);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(72, 51);
            this.cloud1.TabIndex = 5;
            this.cloud1.TabStop = false;
            // 
            // cloud2
            // 
            this.cloud2.Image = ((System.Drawing.Image)(resources.GetObject("cloud2.Image")));
            this.cloud2.Location = new System.Drawing.Point(286, 152);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(72, 51);
            this.cloud2.TabIndex = 6;
            this.cloud2.TabStop = false;
            // 
            // cloud3
            // 
            this.cloud3.Image = ((System.Drawing.Image)(resources.GetObject("cloud3.Image")));
            this.cloud3.Location = new System.Drawing.Point(511, 103);
            this.cloud3.Name = "cloud3";
            this.cloud3.Size = new System.Drawing.Size(72, 51);
            this.cloud3.TabIndex = 7;
            this.cloud3.TabStop = false;
            // 
            // cloud4
            // 
            this.cloud4.Image = ((System.Drawing.Image)(resources.GetObject("cloud4.Image")));
            this.cloud4.Location = new System.Drawing.Point(767, 152);
            this.cloud4.Name = "cloud4";
            this.cloud4.Size = new System.Drawing.Size(72, 51);
            this.cloud4.TabIndex = 8;
            this.cloud4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 553);
            this.Controls.Add(this.dino);
            this.Controls.Add(this.cloud4);
            this.Controls.Add(this.cloud3);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.sun);
            this.Controls.Add(this.tree2);
            this.Controls.Add(this.tree1);
            this.Controls.Add(this.nen);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dino;
        private System.Windows.Forms.PictureBox tree1;
        private System.Windows.Forms.PictureBox tree2;
        private System.Windows.Forms.PictureBox nen;
        private System.Windows.Forms.PictureBox sun;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.PictureBox cloud3;
        private System.Windows.Forms.PictureBox cloud4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

