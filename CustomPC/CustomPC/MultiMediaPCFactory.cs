using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class MultiMediaPCFactory : IPCMaker
    {
        public PCPart makeCPU()
        {
            PCPart currCPU = new MultiMediaCPU();
            return currCPU;
        }

        public PCPart makeMEM()
        {
            PCPart currMem = new MultiMediaMemory();
            return currMem;
        }

        public PCPart makeGPU()
        {
            PCPart currGPU = new MultiMediaGPU();
            return currGPU;
        }
    }
}
