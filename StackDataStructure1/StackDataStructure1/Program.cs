﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStructure1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Stack and Queue implementation program \n");

            StackLinkedList stack = new LinkedListStack();
            //adding elements to stack
            Console.WriteLine(" Adding Elements to stack... - Last Element is 'TOP'.");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.IsEmpty();
        }
    }
}
