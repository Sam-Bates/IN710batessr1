using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Node
    {
        public String str { get; set; }
        public Node next { get; set; }

        public Node(String str)
        {
            this.str = str;
            next = null;
        }
    }
}
