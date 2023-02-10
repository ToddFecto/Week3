using System;
using System.Collections.Generic;

namespace Assessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> produce = new Dictionary<string, decimal>();
            produce.Add("Broccoli", 2.99m);
            produce.Add("Tomatoes", 3.99m);
            produce.Add("Zucchini", 5.99m);

            Dictionary<string, string> actions = new Dictionary<string, string>();
            actions.Add("AddItem   ", "1");
            actions.Add("RemoveItem", "2");
            actions.Add("View Inventory", "3");
            actions.Add("Quit      ", "4");

            Console.WriteLine("Welcome to DevBuild Produce Stand!");

            // Prints out the entire inventory

            Console.WriteLine("Here is a list of our current inventory:");
            int i = 0;
            foreach (var pair in produce)
            {
                Console.WriteLine($"{i + 1} {pair.Key}");
                i++;
            }
            bool keepGoing = true;
            while (keepGoing)
            {
                string choice;
                do
                {
                    Console.WriteLine("\nPlease choose an option from our system menu:");
                    foreach (var pair in actions)
                    {
                        Console.WriteLine($"To {pair.Key} press\t [{pair.Value}]");
                    }
                    Console.Write("\nEnter choice: ");
                    choice = Console.ReadLine().ToLower();
                } while (choice != "1" && choice != "2" && choice != "3" && choice != "4");

                if (choice == "1")
                {
                    //Console.WriteLine("You entered 1");
                    Console.WriteLine("\nYou chose to add a new produce item.");

                    string prod = "";
                    bool tryAgain = true;
                    bool menuCancel = true;
                    while (tryAgain)
                    {

                        Console.Write("How many produce items would you like to enter? ");
                        string itemAdd = Console.ReadLine();
                        decimal prodItems;
                        decimal.TryParse(itemAdd, out prodItems);

                        for (int c = 0; c <= prodItems; c++)
                        {

                            Console.Write("Enter the new produce item name (or type CANCEL to return to the main menu): ");
                            prod = Console.ReadLine();

                            if (prod == "CANCEL")       // Checks if the user entered CANCEL >>>go back to top menu and prompt for new choice
                            {
                                Console.WriteLine("You chose to Cancel this action and start again.");
                                menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop below
                                tryAgain = false;       // Changed so that it breaks out of the while {tryAgain loop
                            }
                            else if (produce.ContainsKey(prod))   // Checks if the item already exists in Dictionary
                            {
                                Console.WriteLine("Sorry that item already exists. Please try again.");
                            }
                            else
                            {
                                tryAgain = false;
                            }
                        }
                    }

                    while (menuCancel)
                    {

                        Console.Write("Enter the item price: $");
                        string price = Console.ReadLine();
                        decimal itemPrice;
                        decimal.TryParse(price, out itemPrice);
                        produce[prod] = itemPrice;

                        Console.WriteLine("\nHere are our updated produce inventory:");
                        foreach (var pair in produce)
                        {
                            Console.WriteLine($"{pair.Key} ${pair.Value}");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop
                        }
                    }
                }
                else if (choice == "2")
                {
                    //Console.WriteLine("You entered R");
                    Console.WriteLine("\nYou chose to remove a produce item.");

                    string Remprod = "";
                    bool tryAgain = true;
                    bool menuCancel = true;
                    while (tryAgain)
                    {
                        Console.Write("Enter the produce item to remove (or type CANCEL to return to the main menu): ");
                        Remprod = Console.ReadLine();

                        if (Remprod == "CANCEL")       // Checks if the user entered CANCEL >>>go back to top menu and prompt for new choice
                        {
                            Console.WriteLine("You chose to Cancel this action and start again.");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop below
                            tryAgain = false;       // Changed so that it breaks out of the while {tryAgain loop
                        }
                        else if (!produce.ContainsKey(Remprod))   // Checks if the item doesn't exist in Dictionary and repeats if not there
                        {
                            Console.WriteLine("Sorry that item doesn't exist. Please try again.");
                        }
                        else
                        {
                            tryAgain = false;
                        }
                    }

                    while (menuCancel)
                    {
                        string prodRem = Remprod;
                        produce.Remove(Remprod);      //Removes the item since action wasn't cancelled and it was determined to exist in dictionary

                        Console.WriteLine($"{prodRem} has been removed from the produce menu!");
                        Console.WriteLine("\nHere is our updated menu items and their prices:");
                        foreach (var pair in produce)
                        {
                            Console.WriteLine($"{pair.Key} ${pair.Value}");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("\nHere is our updated produce inventory:");
                    int count = 0;
                    foreach (var pair in produce)
                    {
                        Console.WriteLine($"{count + 1} {pair.Key}");
                        count++;
                    }
                }




            }
        }
    }
}
