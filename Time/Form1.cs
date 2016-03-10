using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        IClock clock;
        Timer tmr = new Timer();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.updateClock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmr.Start();
            if (clock != null)
            {
                clock.hide();
            }
            if (radioButton1.Checked)
            {
                analogClock1.Visible = false;
                clock = new Digital(label1);
                clock.show();
            }
            else if (radioButton2.Checked)
            {
                label1.Visible = false;
                clock = new Analog();
                clock.show();
            }
        }
    }
}
