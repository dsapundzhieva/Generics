using System;

namespace CustomLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddNodeToHead(5);
            linkedList.AddNodeToHead(6);
            linkedList.AddNodeToHead(7);
            linkedList.AddNodeToEnd(10);
            linkedList.AddNodeToEnd(14);
            linkedList.AddNodeToEnd(17);

            int test = linkedList.RemoveNodeToEnd();
            int test2 = linkedList.RemoveNodeToHead();

            Console.WriteLine(test);
            Console.WriteLine(test2);

            linkedList.PrintList();

            Console.WriteLine(linkedList.Count);
        }
    }
}
