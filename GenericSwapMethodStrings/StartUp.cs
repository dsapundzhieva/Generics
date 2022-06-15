using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                list.Add(input);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var box = new Box<string>(list);

            box.Swap(list, indexes[0], indexes[1]);

            Console.WriteLine(box);
        }
    }
}
