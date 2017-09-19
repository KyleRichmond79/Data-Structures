using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList potatoList = new LinkedList(1);
            potatoList.AddNode(2);
            potatoList.AddNode(3);
            potatoList.AddToFirst(0);
            potatoList.ViewLinkedList();
            Console.Read();
        }
    }
}
