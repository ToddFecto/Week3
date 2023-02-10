using System;
using System.Collections.Generic;

namespace DictionaryDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary of cars
            // Keys are strings representing VIN number
            // Values are strings representing. make and Model (e.g. "Chevy Trax" or "Honda Civic")
            // CRUD = Create, Read, Update, Delete

            Dictionary<string, string> cars = new Dictionary<string, string>();
            cars["FKX14G678"] = "Chevy Trax";
            cars["OJFKGHT5"] = "Honda Civic";
            cars["JF678DNF"] = "Chevy Equinox";
            cars["K4756KJ8"] = "Ford F150";

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
            }
        }
    }
}
