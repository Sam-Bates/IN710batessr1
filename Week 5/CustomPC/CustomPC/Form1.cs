using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPC
{
    public partial class Form1 : Form
    {
        private IPCMaker PCMaker;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbGame.Checked)
            {
                PCMaker = new GamePCFactory();
                MachineSpecPrinter specPrinter = new MachineSpecPrinter(PCMaker, listBox1);
                specPrinter.PrintSpec();
            }
            else if (rbBusiness.Checked)
            {
                PCMaker = new BusinessPCFactory();
                MachineSpecPrinter specPrinter = new MachineSpecPrinter(PCMaker, listBox1);
                specPrinter.PrintSpec();
            }
            else if (rbMultiMedia.Checked)
            {
                PCMaker = new MultiMediaPCFactory();
                MachineSpecPrinter specPrinter = new MachineSpecPrinter(PCMaker, listBox1);
                specPrinter.PrintSpec();
            }
        }
    }
}
