using System;
using System.Collections.Generic;
using System.Text;

namespace StacksQueueKyle
{
    class Stack : LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Stack(int data)
        {
            Head = new Node(data);
            Tail = Head;
        }
        public void Push(int data)
        {
            Node temp = Head;
            Head = new Node(data)
            {
                Next = temp
            };
        }
        public void Pop(int data)
        {
            Node temp = Tail;
            
        }
    }
}
