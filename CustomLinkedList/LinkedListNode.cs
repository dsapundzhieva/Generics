using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class LinkedListNode<T>
    {
        public LinkedListNode<T> NextNode { get; set; }
        public LinkedListNode<T> PreviousNode { get; set; }

        public T Data { get; set; }

        public LinkedListNode(T data)
        {
            this.Data = data;
            this.NextNode = null;
            this.PreviousNode = null;
        }

    }
}
