namespace AnimalWorld
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
            this.btNorthAmerica = new System.Windows.Forms.Button();
            this.btAustralia = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btAsia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNorthAmerica
            // 
            this.btNorthAmerica.Location = new System.Drawing.Point(180, 447);
            this.btNorthAmerica.Name = "btNorthAmerica";
            this.btNorthAmerica.Size = new System.Drawing.Size(87, 23);
            this.btNorthAmerica.TabIndex = 5;
            this.btNorthAmerica.Text = "North America";
            this.btNorthAmerica.UseVisualStyleBackColor = true;
            this.btNorthAmerica.Click += new System.EventHandler(this.btNorthAmerica_Click);
            // 
            // btAustralia
            // 
            this.btAustralia.Location = new System.Drawing.Point(371, 447);
            this.btAustralia.Name = "btAustralia";
            this.btAustralia.Size = new System.Drawing.Size(87, 23);
            this.btAustralia.TabIndex = 6;
            this.btAustralia.Text = "Australia";
            this.btAustralia.UseVisualStyleBackColor = true;
            this.btAustralia.Click += new System.EventHandler(this.btAustralia_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(180, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 264);
            this.listBox1.TabIndex = 7;
            // 
            // btAsia
            // 
            this.btAsia.Location = new System.Drawing.Point(273, 447);
            this.btAsia.Name = "btAsia";
            this.btAsia.Size = new System.Drawing.Size(87, 23);
            this.btAsia.TabIndex = 8;
            this.btAsia.Text = "Asia";
            this.btAsia.UseVisualStyleBackColor = true;
            this.btAsia.Click += new System.EventHandler(this.btAsia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 496);
            this.Controls.Add(this.btAsia);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btAustralia);
            this.Controls.Add(this.btNorthAmerica);
            this.Name = "Form1";
            this.Text = "Animal World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNorthAmerica;
        private System.Windows.Forms.Button btAustralia;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btAsia;
    }
}

