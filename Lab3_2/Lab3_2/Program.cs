using System;
using System.Collections.Generic;

namespace Lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary of Deli items and prices
            // Keys are strings representing menu item
            // Values are strings representing price
            // CRUD = Create, Read, Update, Delete

            //Dictionary<string, string> items = new Dictionary<string, string>();
            //items["Turkey"] = "5.99";
            //items["Ham"] = "7.99";
            //items["Chicken"] = "6.99";
            //items["Steak"] = "8.99";
            //items["Tuna"] = "7.50";

            //Dictionary<string, string> actions = new Dictionary<string, string>();
            //actions["AddItem   "] = "A";
            //actions["RemoveItem"] = "R";
            //actions["ChangeItem"] = "C";
            //actions["Quit      "] = "Q";

            Dictionary<string, decimal> items = new Dictionary<string, decimal>();
            items.Add("Turkey", 5.99m);
            items.Add("Ham", 7.99m);
            items.Add("Chicken", 6.99m);
            items.Add("Steak", 8.99m);
            items.Add("Tuna", 7.50m);

            Dictionary<string, string> actions = new Dictionary<string, string>();
            actions.Add("AddItem   ", "A");
            actions.Add("RemoveItem", "R");
            actions.Add("ChangeItem", "C");
            actions.Add("Quit      ", "Q");


            Console.WriteLine("Welcome to our Deli!");

            // Prints out the entire item menu and prices
            Console.WriteLine("Here are our menu items and their prices:");
            foreach (var pair in items)
            {
                Console.WriteLine($"{pair.Key} ${pair.Value}");
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
                        Console.WriteLine($"To {pair.Key} press\t'{pair.Value}'");
                    }
                    Console.Write("\nEnter choice: ");
                    choice = Console.ReadLine().ToLower();
                } while (choice != "a" && choice != "r" && choice != "c" && choice != "q");


                if (choice == "a")
                {
                    //Console.WriteLine("You entered A");
                    Console.WriteLine("\nYou chose to add a new menu item.");

                    string food = "";
                    bool tryAgain = true;
                    bool menuCancel = true;
                    while (tryAgain)
                    {
                        Console.Write("Enter the new menu item name (or type CANCEL to return to the main menu): ");
                        food = Console.ReadLine();

                        if (food == "CANCEL")       // Checks if the user entered CANCEL >>>go back to top menu and prompt for new choice
                        {
                            Console.WriteLine("You chose to Cancel this action and start again.");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop below
                            tryAgain = false;       // Changed so that it breaks out of the while {tryAgain loop
                        }
                        else if (items.ContainsKey(food))   // Checks if the item already exists in Dictionary
                        {
                            Console.WriteLine("Sorry that item already exists. Please try again.");
                        }
                        else
                        {
                            tryAgain = false;
                        }
                    }

                    while (menuCancel)
                    {

                        Console.Write("Enter the item price: $");
                        string price = Console.ReadLine();
                        decimal itemPrice;
                        decimal.TryParse(price, out itemPrice);
                        items[food] = itemPrice;

                        Console.WriteLine("\nHere are our updated menu items and their prices:");
                        foreach (var pair in items)
                        {
                            Console.WriteLine($"{pair.Key} ${pair.Value}");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop
                        }
                    }
                }
                else if (choice == "r")
                {
                    //Console.WriteLine("You entered R");
                    Console.WriteLine("\nYou chose to remove a menu item.");

                    string Remfood = "";
                    bool tryAgain = true;
                    bool menuCancel = true;
                    while (tryAgain)
                    {
                        Console.Write("Enter the menu item to remove (or type CANCEL to return to the main menu): ");
                        Remfood = Console.ReadLine();

                        if (Remfood == "CANCEL")       // Checks if the user entered CANCEL >>>go back to top menu and prompt for new choice
                        {
                            Console.WriteLine("You chose to Cancel this action and start again.");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop below
                            tryAgain = false;       // Changed so that it breaks out of the while {tryAgain loop
                        }
                        else if (!items.ContainsKey(Remfood))   // Checks if the item doesn't exist in Dictionary and repeats if not there
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
                        items.Remove(Remfood);      //Removes the item since action wasn't cancelled and it was determined to exist in dictionary

                        Console.WriteLine("\nHere is our updated menu items and their prices:");
                        foreach (var pair in items)
                        {
                            Console.WriteLine($"{pair.Key} ${pair.Value}");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop
                        }
                    }
                }
                else if (choice == "c")
                {
                    //Console.WriteLine("You entered C");
                    Console.WriteLine("\nYou chose to change a menu item.");

                    string chgfood = "";
                    bool tryAgain = true;
                    bool menuCancel = true;
                    while (tryAgain)
                    {
                        Console.Write("Enter the menu item to change (or type CANCEL to return to the main menu): ");
                        chgfood = Console.ReadLine();

                        if (chgfood == "CANCEL")       // Checks if the user entered CANCEL >>>go back to top menu and prompt for new choice
                        {
                            Console.WriteLine("You chose to Cancel this action and start again.");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop below
                            tryAgain = false;       // Changed so that it breaks out of the while {tryAgain loop
                        }
                        else if (!items.ContainsKey(chgfood))   // Checks if the item doesn't exist in Dictionary and repeats if not there
                        {
                            Console.WriteLine("Sorry that item doesn't exist. Please try again.");
                        }
                        else if (items.ContainsKey(chgfood))   //Returns/passes the value of key menu item "chgFood" 's value
                        {
                            Console.WriteLine($"This is the current price: ${items[chgfood]}");
                            Console.Write("Enter the item's new price: $");
                            string newPrice = Console.ReadLine();
                            decimal itemNewPrice;
                            decimal.TryParse(newPrice, out itemNewPrice);
                            items[chgfood] = itemNewPrice;
                            menuCancel = true;     // Changed so that it breaks out of the while {menuCancel loop below
                            tryAgain = false;       // Changed so that it breaks out of the while {tryAgain loop
                        }
                        else
                        {
                            tryAgain = false;
                        }
                    }

                    while (menuCancel)
                    {
                        Console.WriteLine("\nHere is our updated menu items and their prices:");
                        foreach (var pair in items)
                        {
                            Console.WriteLine($"{pair.Key} ${pair.Value}");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop
                        }
                    }
                }
                else if (choice == "q")
                {
                    Console.WriteLine("Thank you for stopping by!!");
                    keepGoing = false;
                }
            }
        }
    }
}

