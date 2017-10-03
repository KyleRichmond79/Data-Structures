using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueueKyle
{
    class Queue : LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Queue(int data)
        {
            Head = new Node(data);
            Tail = Head;
        }
        public void AddQ(int data)
        {
            Tail.Next = new Node(data);
        }
    }
}
