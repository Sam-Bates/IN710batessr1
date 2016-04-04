namespace QuizNight
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
            this.ScoreButton = new System.Windows.Forms.Button();
            this.CorrectBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IncorrectBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AdultRB = new System.Windows.Forms.RadioButton();
            this.ChildRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ScoreButton
            // 
            this.ScoreButton.Location = new System.Drawing.Point(12, 80);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(75, 23);
            this.ScoreButton.TabIndex = 0;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            this.ScoreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CorrectBox
            // 
            this.CorrectBox.Location = new System.Drawing.Point(130, 8);
            this.CorrectBox.Name = "CorrectBox";
            this.CorrectBox.Size = new System.Drawing.Size(100, 20);
            this.CorrectBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correct Answers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incorrect Answers";
            // 
            // IncorrectBox
            // 
            this.IncorrectBox.Location = new System.Drawing.Point(130, 39);
            this.IncorrectBox.Name = "IncorrectBox";
            this.IncorrectBox.Size = new System.Drawing.Size(100, 20);
            this.IncorrectBox.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 109);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 147);
            this.listBox1.TabIndex = 5;
            // 
            // AdultRB
            // 
            this.AdultRB.AutoSize = true;
            this.AdultRB.Location = new System.Drawing.Point(223, 109);
            this.AdultRB.Name = "AdultRB";
            this.AdultRB.Size = new System.Drawing.Size(49, 17);
            this.AdultRB.TabIndex = 6;
            this.AdultRB.TabStop = true;
            this.AdultRB.Text = "Adult";
            this.AdultRB.UseVisualStyleBackColor = true;
            // 
            // ChildRB
            // 
            this.ChildRB.AutoSize = true;
            this.ChildRB.Location = new System.Drawing.Point(223, 132);
            this.ChildRB.Name = "ChildRB";
            this.ChildRB.Size = new System.Drawing.Size(48, 17);
            this.ChildRB.TabIndex = 7;
            this.ChildRB.TabStop = true;
            this.ChildRB.Text = "Child";
            this.ChildRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ChildRB);
            this.Controls.Add(this.AdultRB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.IncorrectBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorrectBox);
            this.Controls.Add(this.ScoreButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScoreButton;
        private System.Windows.Forms.TextBox CorrectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IncorrectBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton AdultRB;
        private System.Windows.Forms.RadioButton ChildRB;
    }
}

