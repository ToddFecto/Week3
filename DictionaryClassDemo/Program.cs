using System;
using System.Collections.Generic;
namespace DictionaryClassDemo
{

    class Car
    {
        public string VIN; // Unique across all instances. We call this a "Primary Key".
        public string Make;
        public string Model;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary of cars
            // Keys are strings representing VIN number
            // Values are strings representing. make and Model (e.g. "Chevy Trax" or "Honda Civic")
            // CRUD = Create, Read, Update, Delete

            /*
             * Dictionary<string, string> cars = new Dictionary<string, string>();
            cars["FKX14G678"] = "Chevy Trax";
            cars["OJFKGHT5"] = "Honda Civic";
            cars["JF678DNF"] = "Chevy Equinox";
            cars["K4756KJ8"] = "Ford F150";
            */

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            Car first = new Car();
            first.VIN = "FKX14G678";
            first.Make = "Chevy";
            first.Model = "Trax";
            //Console.WriteLine($"{first.VIN} {first.Make} {first.Model}");

            cars["FKX14G678"] = first;

            foreach (var pair in cars)
            {
                Console.WriteLine("Next car: ");
                Console.WriteLine(pair.Key);
                Console.WriteLine($"{pair.Value.VIN} {pair.Value.Make} {pair.Value.Model}");
            }

            /*
            Console.WriteLine("Here are the make and model of the cars");
            foreach (var pair in cars)
            {
                Console.WriteLine(pair.Value);
            }

            Console.WriteLine("\nHere are all the VINS");
            foreach (var pair in cars)
            {
                Console.WriteLine(pair.Key);
            }

            /*
            //Let's delete the Honda Civic
            cars.Remove("OJFKGHT5");

            while (true)
            {
                Console.WriteLine("\nLet's add a new car");
                Console.Write("Enter the VIN: ");
                string vin = Console.ReadLine();
                Console.Write("Enter the Make and Model: ");
                string mm = Console.ReadLine();
                cars[vin] = mm;

                Console.WriteLine("\nHere are the make and model of the cars");
                foreach (var pair in cars)
                {
                    Console.WriteLine($"{pair.Key} is a {pair.Value}");
                }
            }*/
        }
    }
}
