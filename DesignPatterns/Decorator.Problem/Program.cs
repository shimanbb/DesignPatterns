using System;

namespace Decorator.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1(); ;

            Console.ReadKey();
        }

        private static void Test1()
        {
            Console.WriteLine("Testing Your Car without Decorator Pattern");
            Console.WriteLine("------------------------------------------");
            ICar carWithSpoiler = new CarWithSpoiler();

            Console.WriteLine("Oh snap!!! You wanted a colour... Scrap it and create a new one...");

            ICar colouredCarWithSpoiler = new ColouredCarWithSpoiler("Blue");

            Console.WriteLine(colouredCarWithSpoiler.GetDescription());
        }
    }
}
