using System;

namespace DeleteDataByDataKyle
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList potatoList = new LinkedList(1);
            potatoList.AddNode(2);
            potatoList.AddNode(19);
            potatoList.AddNode(38);
            potatoList.AddNode(63);
            potatoList.AddNode(15);
            potatoList.AddNode(69);
            potatoList.AddNode(85);
            potatoList.AddNode(33);
            potatoList.AddNode(42);
            potatoList.AddNode(27);
            potatoList.AddNode(6);
            potatoList.AddNode(50);
            potatoList.AddNode(99);
            potatoList.AddToFirst(0);
            potatoList.ViewLinkedList();
            Console.WriteLine("what is the center node?");
            potatoList.FindCenterNode();
            Console.WriteLine("What is the Nth from the end?");
            potatoList.NthFromEnd(8);
            Console.WriteLine("What is Data n from end?");
            potatoList.DataNFromEnd(27);
            Console.WriteLine("Let's delete a node!");
            potatoList.DeleteByData(85);
            potatoList.ViewLinkedList();
            Console.Read();
        }
    }
}
