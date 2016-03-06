using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        Node head;
        Node tail;
        public Stack()
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
            }
        }
        public String Pop()
        {
            //get latest string
            String popstr = tail.Str;
            //start at node head
            Node nodewalker = head;
            if (nodewalker == null)
            {
                return "Error: head is null";
            }
            else
            {
                //go to node.next until node.next = tail
                while (nodewalker.Next != tail)
                {
                    nodewalker = nodewalker.Next;
                }
                //make that node tail
                tail = nodewalker;
                //set next node to null
                tail.Next = null;
            }
            return popstr;
        }
        public String Peek()
        {
            return tail.Str;
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
            }
            return count;
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
