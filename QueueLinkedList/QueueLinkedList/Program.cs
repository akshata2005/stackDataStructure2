using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
           QueueLinkedList llqueue = new QueueLinkedList();

            //add elements to queue -- enqueue
            llqueue.EnQueue(56);
            llqueue.EnQueue(30);
            llqueue.EnQueue(70);

            //dispaly queue elements
            Console.Write(" Queue elements : [Top] →");
            llqueue.Display();
            //remove first added element
            llqueue.Dequeue();
            llqueue.Display();
        }
    }
}
