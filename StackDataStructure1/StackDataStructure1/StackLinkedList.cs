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
        // method to pop elements from stack
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine(" The Stack is Empty...");
            }
            else
            {
                Console.WriteLine("\n The Element at top [" + top.data + "] popped from the Stack.");
                top = top.next;
            }
        }
        public void Peak()
        {
            if (top == null)
            {
                Console.WriteLine(" The Stack is Empty... ");
            }
            else
            {
                Console.WriteLine("\n The Element [" + top.data + "] is at top of Stack.");
            }
        }

        public void IsEmpty()
        {
            while (top != null)
            {
                Peak();
                Pop();
            }
            Console.WriteLine(" Now the Stack is empty...");
        }
    }
}
