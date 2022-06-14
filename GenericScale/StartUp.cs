using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var equalityScale = new EqualityScale<int>(4, 5);
            var areEqual = equalityScale.AreEqual();
            Console.WriteLine(areEqual);
        }
    }
}
