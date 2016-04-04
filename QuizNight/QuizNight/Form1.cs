using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNight
{
    public partial class Form1 : Form
    {
        public delegate int ScoreDelegate(int correct, int incorrect);
        ScoreDelegate scoreComputer;

        public Form1()
        {
            InitializeComponent();
            CorrectBox.Text = "0";
            IncorrectBox.Text = "0";
            AdultRB.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int correct = Convert.ToInt32(CorrectBox.Text);
            int incorrect = Convert.ToInt32(IncorrectBox.Text);
            if (AdultRB.Checked)
            {
                scoreComputer = new ScoreDelegate(Scorer.AdultScore);
            }
            else if (ChildRB.Checked)
            {
                scoreComputer = new ScoreDelegate(Scorer.ChildScore);
            }
            int score = scoreComputer(correct, incorrect);
            listBox1.Items.Clear();
            listBox1.Items.Add("Score: " + score);
        }
    }
}
