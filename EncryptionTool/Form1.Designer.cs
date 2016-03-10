namespace EncryptionTool
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.ROT13 = new System.Windows.Forms.RadioButton();
            this.Reversal = new System.Windows.Forms.RadioButton();
            this.outTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 28);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(12, 54);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Encrypt.TabIndex = 1;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // ROT13
            // 
            this.ROT13.AutoSize = true;
            this.ROT13.Location = new System.Drawing.Point(178, 46);
            this.ROT13.Name = "ROT13";
            this.ROT13.Size = new System.Drawing.Size(60, 17);
            this.ROT13.TabIndex = 2;
            this.ROT13.TabStop = true;
            this.ROT13.Text = "ROT13";
            this.ROT13.UseVisualStyleBackColor = true;
            // 
            // Reversal
            // 
            this.Reversal.AutoSize = true;
            this.Reversal.Location = new System.Drawing.Point(178, 69);
            this.Reversal.Name = "Reversal";
            this.Reversal.Size = new System.Drawing.Size(67, 17);
            this.Reversal.TabIndex = 3;
            this.Reversal.TabStop = true;
            this.Reversal.Text = "Reversal";
            this.Reversal.UseVisualStyleBackColor = true;
            // 
            // outTextBox
            // 
            this.outTextBox.Location = new System.Drawing.Point(12, 83);
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.Size = new System.Drawing.Size(100, 20);
            this.outTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.outTextBox);
            this.Controls.Add(this.Reversal);
            this.Controls.Add(this.ROT13);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.RadioButton ROT13;
        private System.Windows.Forms.RadioButton Reversal;
        private System.Windows.Forms.TextBox outTextBox;
    }
}

