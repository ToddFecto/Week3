using System;
using System.Collections.Generic;

namespace TestKey_to_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> types = new Dictionary<string, string>();

            types.Add("TunaSub", "one");
            types.Add("2", "two");
            types.Add("3", "three");

            Console.WriteLine("Please type a key to show its value: ");
            string rLine = Console.ReadLine();

            if (types.ContainsKey(rLine))
            {
                string value_For_Key = types[rLine];
                Console.WriteLine("Value for " + rLine + " is " + value_For_Key);
            }
        }
    }
}
