using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Node
    {
        public String Str { get; set; }
        public Node Next { get; set; }

        public Node(String Str)
        {
            this.Str = Str;
            Next = null;
        }
    }
}
