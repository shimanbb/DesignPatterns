using System;

namespace Decorator.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

            Console.ReadKey();
        }

        private static void Test()
        {
            Console.WriteLine("Testing Your Car with Decorator Pattern");
            Console.WriteLine("---------------------------------------");

            ICar car = new Car();

            car = new Spoiler(car);

            Console.WriteLine("Oh snap!!! You wanted a colour... No worries :)... Decorate it with colour");

            car = new Colour(car, "Blue");

            Console.WriteLine(car.GetDescription());
            Console.WriteLine("\n----------------------------------");

            Console.WriteLine("\nNew Customer wants a Green Car.\n");


            Decorator.Solution.ICar car2 = new Decorator.Solution.Car();

            car2 = new Colour(car2, "Green");

            Console.WriteLine(car2.GetDescription());
        }
    }
}
