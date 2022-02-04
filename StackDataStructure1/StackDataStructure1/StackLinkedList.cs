using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStructure1
{
    public class StackLinkedList
    {
        Node top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            Console.Write(" [" + node.data + "] →");
        }
    }
}
