using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesProgress
{
    public partial class Form1 : Form
    {

        ProgressSubject slowWorker;

        public Form1()
        {
            InitializeComponent();
            slowWorker = new ProgressSubject();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slowWorker.SlowMethod();
        }
        //private void reset()
        //{
        //    progressBar1.Value = 0;
        //    numericUpDown1.Value = 0;
        //    trackBar1.Value = 0;
        //}
        //private void incSpin()
        //{
        //    Application.DoEvents();
        //    numericUpDown1.Value++;
        //}

        //private void incProg()
        //{
        //    progressBar1.Value++;
        //}

        //private void incTrack()
        //{
        //    trackBar1.Value++;
        //}
    }
}

