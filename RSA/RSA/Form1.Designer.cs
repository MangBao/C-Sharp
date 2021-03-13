namespace RSA
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
            this.CreateKey = new System.Windows.Forms.Button();
            this.txtPublic = new System.Windows.Forms.RichTextBox();
            this.txtPrivate = new System.Windows.Forms.RichTextBox();
            this.txtDecrypted = new System.Windows.Forms.RichTextBox();
            this.txtPlain = new System.Windows.Forms.RichTextBox();
            this.txtEncrypted = new System.Windows.Forms.RichTextBox();
            this.btDecripted = new System.Windows.Forms.Button();
            this.txtPlain2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btEncrypted = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateKey
            // 
            this.CreateKey.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateKey.Location = new System.Drawing.Point(466, 132);
            this.CreateKey.Margin = new System.Windows.Forms.Padding(4);
            this.CreateKey.Name = "CreateKey";
            this.CreateKey.Size = new System.Drawing.Size(161, 76);
            this.CreateKey.TabIndex = 6;
            this.CreateKey.Text = "Tạo Key";
            this.CreateKey.UseVisualStyleBackColor = true;
            this.CreateKey.Click += new System.EventHandler(this.CreateKey_Click);
            // 
            // txtPublic
            // 
            this.txtPublic.Location = new System.Drawing.Point(16, 119);
            this.txtPublic.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.Size = new System.Drawing.Size(434, 245);
            this.txtPublic.TabIndex = 9;
            this.txtPublic.Text = "";
            // 
            // txtPrivate
            // 
            this.txtPrivate.Location = new System.Drawing.Point(649, 119);
            this.txtPrivate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.Size = new System.Drawing.Size(434, 245);
            this.txtPrivate.TabIndex = 10;
            this.txtPrivate.Text = "";
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(644, 403);
            this.txtDecrypted.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(434, 69);
            this.txtDecrypted.TabIndex = 11;
            this.txtDecrypted.Text = "";
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(13, 403);
            this.txtPlain.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(434, 69);
            this.txtPlain.TabIndex = 11;
            this.txtPlain.Text = "";
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(8, 570);
            this.txtEncrypted.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(434, 69);
            this.txtEncrypted.TabIndex = 12;
            this.txtEncrypted.Text = "";
            // 
            // btDecripted
            // 
            this.btDecripted.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDecripted.Location = new System.Drawing.Point(811, 480);
            this.btDecripted.Margin = new System.Windows.Forms.Padding(4);
            this.btDecripted.Name = "btDecripted";
            this.btDecripted.Size = new System.Drawing.Size(138, 56);
            this.btDecripted.TabIndex = 13;
            this.btDecripted.Text = "Giải mã ";
            this.btDecripted.UseVisualStyleBackColor = true;
            this.btDecripted.Click += new System.EventHandler(this.btDecripted_Click);
            // 
            // txtPlain2
            // 
            this.txtPlain2.Location = new System.Drawing.Point(644, 570);
            this.txtPlain2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlain2.Name = "txtPlain2";
            this.txtPlain2.Size = new System.Drawing.Size(434, 69);
            this.txtPlain2.TabIndex = 14;
            this.txtPlain2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 61);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã hóa RSA";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 93);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(98, 22);
            this.lb1.TabIndex = 16;
            this.lb1.Text = "Public Key";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(645, 93);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(104, 22);
            this.lb2.TabIndex = 17;
            this.lb2.Text = "Private Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập văn vản vào đây:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhập mã vào đây:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã sau mã hóa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Văn bản sau giải mã:";
            // 
            // btEncrypted
            // 
            this.btEncrypted.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncrypted.Location = new System.Drawing.Point(151, 480);
            this.btEncrypted.Margin = new System.Windows.Forms.Padding(4);
            this.btEncrypted.Name = "btEncrypted";
            this.btEncrypted.Size = new System.Drawing.Size(138, 56);
            this.btEncrypted.TabIndex = 22;
            this.btEncrypted.Text = "Mã hóa";
            this.btEncrypted.UseVisualStyleBackColor = true;
            this.btEncrypted.Click += new System.EventHandler(this.btEncrypted_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(492, 660);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(108, 47);
            this.btReset.TabIndex = 23;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 749);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btEncrypted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlain2);
            this.Controls.Add(this.btDecripted);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.txtPrivate);
            this.Controls.Add(this.txtPublic);
            this.Controls.Add(this.CreateKey);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateKey;
        private System.Windows.Forms.RichTextBox txtPublic;
        private System.Windows.Forms.RichTextBox txtPrivate;
        private System.Windows.Forms.RichTextBox txtDecrypted;
        private System.Windows.Forms.RichTextBox txtPlain;
        private System.Windows.Forms.RichTextBox txtEncrypted;
        private System.Windows.Forms.Button btDecripted;
        private System.Windows.Forms.RichTextBox txtPlain2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEncrypted;
        private System.Windows.Forms.Button btReset;
    }
}

