using System;
using System.Collections.Generic;
using System.Text;

namespace FindMiddleNode
{
    class LinkedList
    {
        public Node Next { get; set; }
        public LinkedList(int data)
        {
            Next = new Node(data);
        }

        public void AddNode(int data)
        {
            Node runner = Next;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = new Node(data);
        }

        public void ViewLinkedList()
        {
            Node runner = Next;
            string printOut = "";
            while (runner.Next != null)
            {
                printOut += runner.Data + "=>";
                runner = runner.Next;
            }
            printOut += runner.Data + "=> null";
            Console.WriteLine(printOut);
        }

        public void AddToFirst(int data)
        {
            Node runner = Next;
            Next = new Node(data);
            Next.Next = runner;
        }

        public void FindCenterNode()
        {
            Node runner = Next;
            double counter = 1;
            while(runner.Next != null)
            {
                runner = runner.Next;
                counter++;
            }
            counter = Math.Floor((counter / 2));
            Console.WriteLine(counter);
            runner = Next;
            while (counter > 1)
            {
                runner = runner.Next;
                counter--;
            }
            Console.WriteLine($"the middle node has the data {runner.Data}.");
        }
    }
}
