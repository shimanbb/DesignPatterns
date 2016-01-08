
using System;
namespace Decorator.Solution
{
    public class Spoiler : CarDecoratorBase
    {
        public Spoiler(ICar car)
        {
            Console.WriteLine("Creating Spoiler");
            this.car = car;
        }

        public override string GetDescription()
        {
            return this.car.GetDescription() + " + Spoiler";
        }
    }
}
