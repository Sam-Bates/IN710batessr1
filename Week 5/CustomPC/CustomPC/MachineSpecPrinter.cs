using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPC
{
    public class MachineSpecPrinter
    {
        public IPCMaker PCMaker;
        public ListBox displayBox;

        public MachineSpecPrinter(IPCMaker PCMaker, ListBox displayBox)
        {
            this.displayBox = displayBox;
            this.PCMaker = PCMaker;
        }

        public void PrintSpec()
        {
            PCPart currCPU = PCMaker.makeCPU();
            PCPart currMEM = PCMaker.makeMEM();
            PCPart currGPU = PCMaker.makeGPU();

            double totalPrice = currCPU.Price + currGPU.Price + currGPU.Price;

            displayBox.Items.Clear();
            displayBox.Items.Add("Price / Component");
            displayBox.Items.Add("-----------------");
            displayBox.Items.Add("CPU: " + currCPU.Price + " --- " + currCPU.Name);
            displayBox.Items.Add("GPU: " + currGPU.Price + " --- " + currGPU.Name);
            displayBox.Items.Add("MEM: " + currMEM.Price + " --- " + currMEM.Name);
            displayBox.Items.Add("-----------------");
            displayBox.Items.Add("Total Price: " + totalPrice);
        }
    }
}
