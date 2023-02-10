using System;
using System.Collections.Generic;

namespace ClassDemo2
{

    class Car
    {
        public string VIN;
        public string Make;
        public string Model;
        public int DoorCount;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the first car
            Car first = new Car();
            first.VIN = "ABC123";
            first.Make = "Ford";
            first.Model = "Taurus";
            first.DoorCount = 2;

            Console.WriteLine(first.VIN);
            Console.WriteLine(first.Make);
            Console.WriteLine(first.Model);
            Console.WriteLine(first.DoorCount);

            // Create the second car
            Car second = new Car();
            second.VIN = "ASDFFG345";
            second.Make = "Chevy";
            second.Model = "Equinox";
            second.DoorCount = 4;

            Console.WriteLine(second.VIN);
            Console.WriteLine(second.Make);
            Console.WriteLine(second.Model);
            Console.WriteLine(second.DoorCount);

            // Now let's make a list and ADD the two instances
            List<Car> mycars = new List<Car>();
            mycars.Add(first);
            mycars.Add(second);

            Console.WriteLine("\nIndividual Makes:");
            Console.WriteLine(mycars[0].Make);  //We access the individual items in the list with brackets and index number
            Console.WriteLine(mycars[1].Make);

            // Loop with regular For
            Console.WriteLine("\nLoop with a regular For");
            for (int i = 0; i < mycars.Count; i++)
            {
                Console.WriteLine($"{mycars[i].VIN} {mycars[i].Make} {mycars[i].DoorCount}");
            }

            // Loop with a foreach
            Console.WriteLine("\nLoop with foreach:");
            foreach (Car next in mycars)
            {
                Console.WriteLine($"{next.VIN} {next.Make} {next.Model} {next.DoorCount}");
            }
        }
    }
}
