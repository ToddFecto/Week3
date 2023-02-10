using System;

namespace ArrayDemo2
{
    class Program
    {
        static bool KeepGoing()
        {
            // Version 0.04. (Agile Programming)

            while (true)
            {

                // Print out message asking if user wants to continue

                Console.WriteLine("Would you like to go again? (y/n)");

                // Ask the user for their input

                string response = Console.ReadLine();
                response = response.ToLower();

                // Check if they typed "y". If so, return true.
                // Otherwise return false.   YES   yes

                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }
            }

        }
        static void Main(string[] args)
        {
            // Let's create three arrays.
            // Together these arrays will represent item names and prices at a grocery store

            // First array will hold names. It will be an array of strings.
            // Second array will hold prices. It will be an array of decimal.
            // Third array will hold quantities. It will be an array of integers.

            string[] names = { " Apple", "Banana", "Cucumber" };
            decimal[] prices = { 0.99m, 0.82m, 1.25m };
            int[] quantities = { 30, 25, 45 };

            do
            {
                Console.WriteLine("Menu");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i} {names[i]}");
                }
                Console.Write("Enter a number for the item. Or enter A to show all. ");
                string entry = Console.ReadLine();
                if (entry == "A")
                {
                    // print everything
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine($"{i} {names[i]} {prices[i]} {quantities[i]}");
                    }
                }
                else
                {
                    // Convert it to a number, for an index into the arrays
                    int choice = int.Parse(entry);
                    Console.WriteLine($"{choice} {names[choice]} {prices[choice]} {quantities[choice]}");
                }
            }
            while (KeepGoing());
        }
    }
}
