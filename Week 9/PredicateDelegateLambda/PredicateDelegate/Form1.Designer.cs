namespace PredicateDelegateLambda
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
            this.generateBT = new System.Windows.Forms.Button();
            this.evenBT = new System.Windows.Forms.Button();
            this.lessThan10BT = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // generateBT
            // 
            this.generateBT.Location = new System.Drawing.Point(36, 65);
            this.generateBT.Name = "generateBT";
            this.generateBT.Size = new System.Drawing.Size(118, 26);
            this.generateBT.TabIndex = 0;
            this.generateBT.Text = "Generate Randoms";
            this.generateBT.UseVisualStyleBackColor = true;
            this.generateBT.Click += new System.EventHandler(this.generateBT_Click);
            // 
            // evenBT
            // 
            this.evenBT.Location = new System.Drawing.Point(184, 65);
            this.evenBT.Name = "evenBT";
            this.evenBT.Size = new System.Drawing.Size(120, 26);
            this.evenBT.TabIndex = 1;
            this.evenBT.Text = "Select Even Numbers";
            this.evenBT.UseVisualStyleBackColor = true;
            this.evenBT.Click += new System.EventHandler(this.evenBT_Click);
            // 
            // lessThan10BT
            // 
            this.lessThan10BT.Location = new System.Drawing.Point(184, 107);
            this.lessThan10BT.Name = "lessThan10BT";
            this.lessThan10BT.Size = new System.Drawing.Size(120, 24);
            this.lessThan10BT.TabIndex = 2;
            this.lessThan10BT.Text = "Select Numbers < 10";
            this.lessThan10BT.UseVisualStyleBackColor = true;
            this.lessThan10BT.Click += new System.EventHandler(this.lessThan10BT_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 316);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(184, 161);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 316);
            this.listBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 489);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lessThan10BT);
            this.Controls.Add(this.evenBT);
            this.Controls.Add(this.generateBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateBT;
        private System.Windows.Forms.Button evenBT;
        private System.Windows.Forms.Button lessThan10BT;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

