using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPC
{
    abstract class PCPart
    {
        protected string name;
        protected int price;

        public abstract override string ToString()
        {
            return name + "," + price;
        }
    }
}
