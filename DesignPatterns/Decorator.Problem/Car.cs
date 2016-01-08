using System;

namespace Decorator.Problem
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
