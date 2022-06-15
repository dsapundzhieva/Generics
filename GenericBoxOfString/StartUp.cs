using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var box1 = new Box<string>(Console.ReadLine());
                Console.WriteLine(box1);
            }
        }
    }
}
