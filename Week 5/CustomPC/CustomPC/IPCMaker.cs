using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    public interface IPCMaker
    {
        PCPart makeCPU();
        PCPart makeMEM();
        PCPart makeGPU();
    }
}
