using System;

namespace Decorator.Solution
{
    public class Car : ICar
    {
        public Car()
        {
            Console.WriteLine("Creating Car");
        }
        public string GetDescription()
        {
            return "Car";
        }
    }
}
