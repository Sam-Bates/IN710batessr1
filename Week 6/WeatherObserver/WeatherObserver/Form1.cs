using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherObserver
{
    public partial class Form1 : Form
    {
        Subject subject;
        UnitObserver unitObserver;
        AverageObserver averageObserver;
        ForecastObserver forecastObserver;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new Subject();
            unitObserver = new UnitObserver(listBox1, subject);
            averageObserver = new AverageObserver(listBox2, subject);
            forecastObserver = new ForecastObserver(listBox3, subject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subject.UpdateValues(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
        }
    }
}
