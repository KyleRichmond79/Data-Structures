using DoublyLinkedListsKyle;
using System;

namespace DoublyLinkedListKyle
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList myDoublyLinkedList = new DoublyLinkedList(4);

            myDoublyLinkedList.AddFirst(1);
            myDoublyLinkedList.AddFirst(2);
            myDoublyLinkedList.AddFirst(3);
            myDoublyLinkedList.AddFirst(4);
            myDoublyLinkedList.AddFirst(5);
            myDoublyLinkedList.AddLast(6);
            myDoublyLinkedList.AddLast(7);
            myDoublyLinkedList.AddLast(8);
            myDoublyLinkedList.AddLast(9);

            myDoublyLinkedList.ViewList();
            Console.WriteLine();

            Console.WriteLine("Let's remove 6:");
            myDoublyLinkedList.RemoveByData(6);
            myDoublyLinkedList.ViewList();
            Console.WriteLine();

            Console.WriteLine("Now let's remove the first node:");
            myDoublyLinkedList.RemoveFirst();
            myDoublyLinkedList.ViewList();
            Console.WriteLine();

            Console.WriteLine("Nice Job!");
            Console.Read();
        }
    }
}
