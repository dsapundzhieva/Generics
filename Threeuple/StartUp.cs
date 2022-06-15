using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] firsInput = Console.ReadLine().Split().ToArray();
            string name = firsInput[0] + " " + firsInput[1];
            Tuple<string, string, string> first = new Tuple<string, string, string>(name, firsInput[2], string.Join(" ", firsInput.Skip(3)));

            var secondInput = Console.ReadLine().Split();
            Tuple<string, int, bool> second = new Tuple<string, int, bool>(secondInput[0], int.Parse(secondInput[1]), secondInput[2] == "drunk" ? true : false);

            var thirdInput = Console.ReadLine().Split();
            Tuple<string, double, string> third = new Tuple<string, double, string>(thirdInput[0], double.Parse(thirdInput[1]), thirdInput[2]);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

        }
    }
}
