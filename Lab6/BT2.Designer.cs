namespace Lab6
{
    partial class BT2
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
            this.anh1 = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anh1)).BeginInit();
            this.SuspendLayout();
            // 
            // anh1
            // 
            this.anh1.Location = new System.Drawing.Point(238, 28);
            this.anh1.Name = "anh1";
            this.anh1.Size = new System.Drawing.Size(434, 394);
            this.anh1.TabIndex = 0;
            this.anh1.TabStop = false;
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.open.Location = new System.Drawing.Point(183, 482);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(87, 40);
            this.open.TabIndex = 1;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.exit.Location = new System.Drawing.Point(636, 482);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 40);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // BT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 564);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.open);
            this.Controls.Add(this.anh1);
            this.Name = "BT2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anh1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox anh1;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button exit;
    }
}