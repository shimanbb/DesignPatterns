using System;

namespace Decorator.Problem
{
    public class ColouredCarWithSpoiler : CarWithSpoiler, ICar
    {
        public string Colour { get; set; }


        public ColouredCarWithSpoiler(string colour)
        {
            Console.WriteLine("Creating ColouredCarWithSpoiler");

            Colour = colour;
        }

        public string GetDescription()
        {
            return Colour + " " + base.GetDescription();
        }
    }
}
