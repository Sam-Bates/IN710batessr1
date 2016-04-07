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
        
        public delegate void progressDelegate();
        progressDelegate Delegate;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            if (SpinRB.Checked)
            {
                Delegate = new progressDelegate(incSpin);
            }
            else if (ProgressRB.Checked)
            {
                Delegate = new progressDelegate(incProg);
            }
            else if (TrackRB.Checked)
            {
                Delegate = new progressDelegate(incTrack);
            }
            slowMethod(Delegate);
        }
        private void slowMethod(progressDelegate Delegate)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(40);
                Delegate();
            }
        }
        private void reset()
        {
            progressBar1.Value = 0;
            numericUpDown1.Value = 0;
            trackBar1.Value = 0;
        }
        private void incSpin()
        {
            Application.DoEvents();
            numericUpDown1.Value++;
        }

        private void incProg()
        {
            progressBar1.Value++;
        }

        private void incTrack()
        {
            trackBar1.Value++;
        }
    }
}

