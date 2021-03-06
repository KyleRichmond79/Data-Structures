﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListsKyle
{
    class DNode
    {
        public int Data { get; set; }
        public DNode Next { get; set; }
        public DNode Previous { get; set; }

        public DNode(int data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }
}