using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary of people (employee IS number [integer] and employee name [string])
            //
            //   key    value
            //   25     Fred            (This is a key-value pair consisting of  key:25, value:Fred)
            //   22     Sally                                                    key:22, value:Sally
            //   57     Julie                                                    key:57, value:Julie
            //   98     Sam                                                      key:98, value:Sam

            Dictionary<int, string> people = new Dictionary<int, string>();

            people[25] = "Fred";
            people[22] = "Sally";
            people[57] = "Julie";
            people[98] = "Sam";

            // Print out a couple of them
            //Console.WriteLine(people[22]);

            foreach (var pair in people) 
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

        }
    }
}
