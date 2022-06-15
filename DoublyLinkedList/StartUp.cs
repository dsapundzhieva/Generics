using System;

namespace DoublyLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var linkedList = new DoublyLinkedList<int>();
            linkedList.AddHead(6);
            linkedList.AddHead(7);
            linkedList.AddHead(8);
            linkedList.AddHead(9);
            linkedList.AddHead(63);
            linkedList.AddTail(8);
            linkedList.AddTail(84);
            linkedList.AddTail(58);

            linkedList.RemoveHead();
            linkedList.RemoveTail();

            
        }
    }
}
