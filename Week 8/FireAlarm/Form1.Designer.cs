namespace FireAlarm
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
            this.fireBT = new System.Windows.Forms.Button();
            this.minorRB = new System.Windows.Forms.RadioButton();
            this.seriousRB = new System.Windows.Forms.RadioButton();
            this.infernoRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // fireBT
            // 
            this.fireBT.Location = new System.Drawing.Point(45, 12);
            this.fireBT.Name = "fireBT";
            this.fireBT.Size = new System.Drawing.Size(121, 59);
            this.fireBT.TabIndex = 0;
            this.fireBT.Text = "Fire";
            this.fireBT.UseVisualStyleBackColor = true;
            this.fireBT.Click += new System.EventHandler(this.fireBT_Click);
            // 
            // minorRB
            // 
            this.minorRB.AutoSize = true;
            this.minorRB.Location = new System.Drawing.Point(77, 77);
            this.minorRB.Name = "minorRB";
            this.minorRB.Size = new System.Drawing.Size(51, 17);
            this.minorRB.TabIndex = 1;
            this.minorRB.TabStop = true;
            this.minorRB.Text = "Minor";
            this.minorRB.UseVisualStyleBackColor = true;
            // 
            // seriousRB
            // 
            this.seriousRB.AutoSize = true;
            this.seriousRB.Location = new System.Drawing.Point(77, 100);
            this.seriousRB.Name = "seriousRB";
            this.seriousRB.Size = new System.Drawing.Size(60, 17);
            this.seriousRB.TabIndex = 2;
            this.seriousRB.TabStop = true;
            this.seriousRB.Text = "Serious";
            this.seriousRB.UseVisualStyleBackColor = true;
            // 
            // infernoRB
            // 
            this.infernoRB.AutoSize = true;
            this.infernoRB.Location = new System.Drawing.Point(77, 123);
            this.infernoRB.Name = "infernoRB";
            this.infernoRB.Size = new System.Drawing.Size(58, 17);
            this.infernoRB.TabIndex = 3;
            this.infernoRB.TabStop = true;
            this.infernoRB.Text = "Inferno";
            this.infernoRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 231);
            this.Controls.Add(this.infernoRB);
            this.Controls.Add(this.seriousRB);
            this.Controls.Add(this.minorRB);
            this.Controls.Add(this.fireBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fireBT;
        private System.Windows.Forms.RadioButton minorRB;
        private System.Windows.Forms.RadioButton seriousRB;
        private System.Windows.Forms.RadioButton infernoRB;
    }
}

