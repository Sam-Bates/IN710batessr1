using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class BusinessPCFactory : IPCMaker
    {
        public PCPart makeCPU()
        {
            PCPart currCPU = new BusinessCPU();
            return currCPU;
        }

        public PCPart makeMEM()
        {
            PCPart currMem = new BusinessMemory();
            return currMem;
        }

        public PCPart makeGPU()
        {
            PCPart currGPU = new BusinessGPU();
            return currGPU;
        }
    }
}
