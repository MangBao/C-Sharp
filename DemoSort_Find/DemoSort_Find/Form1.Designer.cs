
namespace DemoSort_Find
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.MaskedTextBox();
            this.btSort = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 253);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 34);
            this.textBox1.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(158, 105);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(328, 34);
            this.txtInput.TabIndex = 1;
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(257, 159);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(136, 54);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "Sắp xếp";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(257, 313);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(136, 54);
            this.btFind.TabIndex = 3;
            this.btFind.Text = "Tìm vị trí";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 449);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox txtInput;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Button btFind;
    }
}

