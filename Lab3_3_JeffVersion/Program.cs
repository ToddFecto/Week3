using System;
using System.Collections.Generic;

namespace Lab3_3_JeffVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> Menu = new Dictionary<string, decimal>();

            Menu.Add("Apple", 0.55m);
            Menu.Add("Cheddar Cheese", 0.99m);
            Menu.Add("Roast Beef", 1.49m);

            Console.WriteLine("Welcome to the Deli");
            bool keepGoing = true;
            while (keepGoing)
            {
                // Print the menu
                Console.WriteLine();
                foreach (var item in Menu)
                {
                    Console.WriteLine($"{item.Key} {item.Value}");
                }

                string choice;
                do
                {

                    Console.WriteLine("\nChoose (A)dd (R)emove (C)hange or (Q)uit");
                    choice = Console.ReadLine().ToUpper();
                } while (choice != "A" && choice != "R" && choice != "C" && choice != "Q");


                if (choice == "A")
                {
                    Console.WriteLine("Let's add a new menu item");

                    string itemname = "";
                    bool goAgain = true;
                    while (goAgain)
                    {


                        Console.WriteLine("Please enter a name for this item: ");
                        itemname = Console.ReadLine();

                        // Check if the item already exists
                        if (Menu.ContainsKey(itemname))
                        {
                            Console.WriteLine("Sorry that item already exists. Please try again.");
                        }
                        else
                        {
                            goAgain = false;
                        }
                    }
                    Console.Write("Please enter a price for this item: ");
                    string priceString = Console.ReadLine();
                    decimal itemprice;
                    decimal.TryParse(priceString, out itemprice);
                    Menu[itemname] = itemprice;
                }
                else if (choice == "R")
                {
                    Console.WriteLine("What item would you like to remove?");
                    string itemname = Console.ReadLine();
                    Menu.Remove(itemname);
                }
                else if (choice == "C")
                {
                    Console.WriteLine("What item would you like to change?");
                    string itemname = Console.ReadLine();
                    Console.Write($"The current price is {Menu[itemname]}. Please enter a price for this item: ");
                    string priceString = Console.ReadLine();
                    decimal itemprice;
                    decimal.TryParse(priceString, out itemprice);
                    Menu[itemname] = itemprice;
                }
                else if (choice == "Q")
                {
                    Console.WriteLine("\nGood bye!");
                    keepGoing = false;
                }

            }
        }
    }
}
