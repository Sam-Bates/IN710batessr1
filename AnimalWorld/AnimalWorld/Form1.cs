using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Random rd;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = this.CreateGraphics();
            rd = new Random();
        }

        private void btNorthAmerica_Click(object sender, EventArgs e)
        {
            NorthAmerica NorthAmerica = new NorthAmerica(listBox1, rd, graphics);
            NorthAmerica.runSim();
        }

        private void btAustralia_Click(object sender, EventArgs e)
        {
            Australia oz = new Australia(listBox1, rd, graphics);
            oz.runSim();
        }
    }
}
