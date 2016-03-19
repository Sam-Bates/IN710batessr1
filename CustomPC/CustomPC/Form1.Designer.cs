namespace CustomPC
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
            this.button1 = new System.Windows.Forms.Button();
            this.rbGame = new System.Windows.Forms.RadioButton();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.rbMultiMedia = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print Spec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbGame
            // 
            this.rbGame.AutoSize = true;
            this.rbGame.Location = new System.Drawing.Point(12, 56);
            this.rbGame.Name = "rbGame";
            this.rbGame.Size = new System.Drawing.Size(53, 17);
            this.rbGame.TabIndex = 1;
            this.rbGame.TabStop = true;
            this.rbGame.Text = "Game";
            this.rbGame.UseVisualStyleBackColor = true;
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Location = new System.Drawing.Point(12, 79);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(67, 17);
            this.rbBusiness.TabIndex = 2;
            this.rbBusiness.TabStop = true;
            this.rbBusiness.Text = "Business";
            this.rbBusiness.UseVisualStyleBackColor = true;
            // 
            // rbMultiMedia
            // 
            this.rbMultiMedia.AutoSize = true;
            this.rbMultiMedia.Location = new System.Drawing.Point(12, 102);
            this.rbMultiMedia.Name = "rbMultiMedia";
            this.rbMultiMedia.Size = new System.Drawing.Size(76, 17);
            this.rbMultiMedia.TabIndex = 3;
            this.rbMultiMedia.TabStop = true;
            this.rbMultiMedia.Text = "MultiMedia";
            this.rbMultiMedia.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(103, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 186);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 203);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rbMultiMedia);
            this.Controls.Add(this.rbBusiness);
            this.Controls.Add(this.rbGame);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "PC Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbGame;
        private System.Windows.Forms.RadioButton rbBusiness;
        private System.Windows.Forms.RadioButton rbMultiMedia;
        private System.Windows.Forms.ListBox listBox1;
    }
}

