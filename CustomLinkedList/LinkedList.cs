using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; set; }

        public LinkedListNode<T> Tail { get; set; }

        public int Count { get; set; }

        public bool IsEmpty => this.Count == 0;

        public LinkedList()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public void AddNodeToHead(T value)
        {
            if (this.IsEmpty)
            {
                this.Head = this.Tail = new LinkedListNode<T>(value);
            }
            else
            {
                LinkedListNode<T> newNode = new LinkedListNode<T>(value);
                var previousHead = this.Head;

                previousHead.PreviousNode = newNode;
                newNode.NextNode = previousHead;
                this.Head = newNode;
            }
            this.Count++;
        }
        public void AddNodeToEnd(T value)
        {
            if (this.IsEmpty)
            {
                this.Tail = this.Head = new LinkedListNode<T>(value);
            }
            else
            {
                LinkedListNode<T> newNode = new LinkedListNode<T>(value);
                var previousTail = this.Tail;
                newNode.PreviousNode = previousTail;
                previousTail.NextNode = newNode;
                this.Tail = newNode;
               
            }
            this.Count++;
        }
        public T RemoveNodeToHead()
        {
            if (this.IsEmpty)
            {
                throw new ArgumentException("List is empty");
            }
            var removedHead = this.Head;
            var removedHeadValue = removedHead.Data;
            var nextHead = this.Head.NextNode;

            if (nextHead == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextHead.PreviousNode = null;
                this.Head = nextHead;
            }
            this.Count--;

            return removedHeadValue;
        }
        public T RemoveNodeToEnd()
        {
            if (this.IsEmpty)
            {
                throw new ArgumentException("List is empty");
            }

            var removedTail = this.Tail;
            var removedValue = removedTail.Data;

            var nextTail = removedTail.PreviousNode;
           
            if (nextTail == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                removedTail.PreviousNode = null;
                nextTail.NextNode = null;

                this.Tail = nextTail;
            }

            this.Count--;

            return removedValue;
        }

        public void PrintList()
        {
            LinkedListNode<T> runner = this.Head;

            while (runner != null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.NextNode;
            }
        }
    }
}
