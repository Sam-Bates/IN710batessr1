namespace DelegatesProgress
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.SpinRB = new System.Windows.Forms.RadioButton();
            this.ProgressRB = new System.Windows.Forms.RadioButton();
            this.TrackRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(152, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(174, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(152, 71);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(174, 45);
            this.trackBar1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // SpinRB
            // 
            this.SpinRB.AutoSize = true;
            this.SpinRB.Location = new System.Drawing.Point(12, 42);
            this.SpinRB.Name = "SpinRB";
            this.SpinRB.Size = new System.Drawing.Size(67, 17);
            this.SpinRB.TabIndex = 4;
            this.SpinRB.TabStop = true;
            this.SpinRB.Text = "Spin Box";
            this.SpinRB.UseVisualStyleBackColor = true;
            // 
            // ProgressRB
            // 
            this.ProgressRB.AutoSize = true;
            this.ProgressRB.Location = new System.Drawing.Point(12, 65);
            this.ProgressRB.Name = "ProgressRB";
            this.ProgressRB.Size = new System.Drawing.Size(85, 17);
            this.ProgressRB.TabIndex = 5;
            this.ProgressRB.TabStop = true;
            this.ProgressRB.Text = "Progress Bar";
            this.ProgressRB.UseVisualStyleBackColor = true;
            // 
            // TrackRB
            // 
            this.TrackRB.AutoSize = true;
            this.TrackRB.Location = new System.Drawing.Point(12, 88);
            this.TrackRB.Name = "TrackRB";
            this.TrackRB.Size = new System.Drawing.Size(72, 17);
            this.TrackRB.TabIndex = 6;
            this.TrackRB.TabStop = true;
            this.TrackRB.Text = "Track Bar";
            this.TrackRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 118);
            this.Controls.Add(this.TrackRB);
            this.Controls.Add(this.ProgressRB);
            this.Controls.Add(this.SpinRB);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton SpinRB;
        private System.Windows.Forms.RadioButton ProgressRB;
        private System.Windows.Forms.RadioButton TrackRB;
    }
}

