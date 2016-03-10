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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ROT13 = new System.Windows.Forms.RadioButton();
            this.Reversal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Reversal);
            this.Controls.Add(this.ROT13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton ROT13;
        private System.Windows.Forms.RadioButton Reversal;
    }
}

