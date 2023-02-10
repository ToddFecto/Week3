using System;
using System.Collections.Generic;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> numbers = new List<int>();
            // numbers.Add(3);

            // Strings are the one exception to the rule that we need the "new" keyword for the heap variables
            // string FirstName = "Fred"

            // All other objects on the heap require the new keyword

            List<string> names = new List<string>();
            names.Add("Fred");
            names.Add("Sally");
            names.Add("Julie");

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names.Count);

            names.Add("Sam");
            Console.WriteLine(names[2]);
            Console.WriteLine(names.Count);

            // Sally got a new job elsewhere
            Console.WriteLine("\nSally left. remove her from the list.");
            names.RemoveAt(1);

            // There are at least two ways to loop through this list
            Console.WriteLine("\nFirst way to loop. A for loop.");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Index {i} holds {names[i]}");
            }

            Console.WriteLine("\nSecond way to loop. A foreach loop.");
            foreach (string person in names)
            {
                Console.WriteLine(person);
            }
        }
    }
}
