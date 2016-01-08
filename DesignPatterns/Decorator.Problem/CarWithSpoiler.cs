using System;

namespace Decorator.Problem
{
    public class CarWithSpoiler : Car, ICar
    {
        public string Spoiler { get; set; }

        public CarWithSpoiler()
        {
            Console.WriteLine("Creating CarWithSpoiler");
            Spoiler = "Spoiler";
        }

        public string GetDescription()
        {
            return base.GetDescription() + " " + Spoiler;
        }
    }
}
