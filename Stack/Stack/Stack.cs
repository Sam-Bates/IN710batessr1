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
            //delete latest node
            Node nodewalker = head;
            //start at node head
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
        }
        public int Count()
        { 
        }
        public bool IsEmpty()
        { 
        }
    }
}
