using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class BusinessGPU : PCPart
    {
        public BusinessGPU()
        {
            Name = "Intel® HD Graphics onboard";
            //this is 0 because it comes with the CPU
            Price = 0;
        }
    }
}
