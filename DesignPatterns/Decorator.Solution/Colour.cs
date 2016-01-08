
using System;
namespace Decorator.Solution
{
    public class Colour : CarDecoratorBase
    {
        string _colour;

        public Colour(ICar car, string colour)
        {
            Console.WriteLine("Applying Colour");
            this.car = car;
            _colour = colour;
        }

        public override string GetDescription()
        {
            return _colour + " " + this.car.GetDescription();
        }
    }
}
