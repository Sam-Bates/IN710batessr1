using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackList
    {
        Node head;
        Node tail;
        public StackList()
        {
            head = null;
            tail = null;
        }
        public void Push(string Str)
        {
            Node node = new Node(Str);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
        public String Pop()
        {
            //get latest string
            String popstr = Peek();
            //start at node head
            
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                Node nodewalker = head;
                //go to node.next until node.next = tail
                while (nodewalker.Next != tail)
                {
                    nodewalker = nodewalker.Next;
                }
                nodewalker.Next = null;
                tail = nodewalker;
            }
            return popstr;
        }
        public String Peek()
        {
            String str;
            if (tail == null)
            {
                throw new System.InvalidOperationException("Empty stack");
            }

            str = tail.Str;
            return str;
        }
        public int Count()
        {
            Node nodewalker = head;
            int count = 0;
            if (nodewalker == null)
            {
                return 0;
            }
            while (nodewalker.Next != null)
            {
                count++;
                nodewalker = nodewalker.Next;
            }
            return count+1;
        }
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            return false;
        }
    }
}
