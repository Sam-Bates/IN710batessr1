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
        }
        
    }
}
