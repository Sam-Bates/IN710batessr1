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
        int nAnimalTypes;

        public Form1()
        {
            InitializeComponent();
            Graphics graphics = this.CreateGraphics();
            rd = new Random();

        }

        private void btNorthAmerica_Click(object sender, EventArgs e)
        {
            NorthAmerica NorthAmerica = new NorthAmerica(listBox1, rd, graphics);
        }
    }
}
