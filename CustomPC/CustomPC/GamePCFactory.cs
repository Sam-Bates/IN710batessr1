using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    class GamePCFactory : IPCMaker
    {
        public PCPart makeCPU()
        {
            PCPart currCPU = new GameCPU();
            return currCPU;
        }

        public PCPart makeMEM()
        {
            PCPart currMem = new GameMemory();
            return currMem;
        }

        public PCPart makeGPU()
        {
            PCPart currGPU = new GameGPU();
            return currGPU;
        }
    }
}
