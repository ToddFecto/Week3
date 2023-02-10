using System;
using System.Collections.Generic;
namespace ClassDemo3
{

    class Pen
    {
        public string Color;
        public double InkAmount;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pen first = new Pen();
            first.Color = "Red";
            first.InkAmount = 4.0;

            Pen second = new Pen();
            second.Color = "Blue";
            second.InkAmount = 5.0;

            // Let's put these in a dictionary
            // Here's how it will work
            //
            // Key (string) Value (Pen)
            // Sally        Red 4.0
            // Fred         Blue 5.0

            Dictionary<string, Pen> pens = new Dictionary<string, Pen>();
            pens["Sally"] = first;
            pens["Fred"] = second;

            // Print out individual pens and their members
            Console.WriteLine("Sally's Pen:");
            Console.WriteLine(pens["Sally"].Color);
            Console.WriteLine(pens["Sally"].InkAmount);

            Console.WriteLine("\nFred's Pen:");
            Console.WriteLine(pens["Fred"].Color);
            Console.WriteLine(pens["Fred"].InkAmount);
        }
    }
}
