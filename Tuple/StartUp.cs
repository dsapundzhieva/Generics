using System;

namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var firsInput = Console.ReadLine().Split();
            string name = firsInput[0] + " " + firsInput[1];
            Tuple<string, string> first = new Tuple<string, string>(name, firsInput[2]);

            var secondInput = Console.ReadLine().Split();
            Tuple<string, int> second = new Tuple<string, int>(secondInput[0], int.Parse(secondInput[1]));

            var thirdInput = Console.ReadLine().Split();
            Tuple<int, double> third = new Tuple<int, double>(int.Parse(thirdInput[0]), double.Parse(thirdInput[1]));

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

        }
    }
}
