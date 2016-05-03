using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleObserver
{
    public partial class Form1 : Form
    {
        Subject subject;
        ObserverRPMDisplay RPM;
        ObserverCalorieDisplay CAL;
        ObserverSpeedDisplay DIS;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new Subject();
            RPM = new ObserverRPMDisplay(label1, subject);
            CAL = new ObserverCalorieDisplay(label2, subject);
            DIS = new ObserverSpeedDisplay(label3, subject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RPM = Int32.Parse(textBox1.Text);
            subject.CurrentRPM = RPM;
            subject.NotifyObservers();
        }
    }
}
