using System;

namespace FindMiddleNode
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
            potatoList.FindCenterNode();
            Console.Read();
        }
    }
}
