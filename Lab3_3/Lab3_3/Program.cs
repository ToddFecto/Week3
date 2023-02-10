using System;
using System.Collections.Generic;

namespace Lab3_3
{
    class MenuItem
    {
        public string name;
        public decimal price;
        public int quantity;

        public void Sell(int howMany)
        {
            quantity -= howMany;
        }
    }

    class Program
    {
         static void Main(string[] args)
        {
            // Create first instance of MenuItem
            MenuItem item1 = new MenuItem();
            item1.name = "Turkey";
            item1.price = 5.99m;
            item1.quantity = 5;

            MenuItem item2 = new MenuItem();
            item2.name = "Ham";
            item2.price = 7.99m;
            item2.quantity = 4;

            MenuItem item3 = new MenuItem();
            item3.name = "Chicken";
            item3.price = 6.99m;
            item3.quantity = 3;

            MenuItem item4 = new MenuItem();
            item4.name = "Steak";
            item4.price = 8.99m;
            item4.quantity = 3;

            MenuItem item5 = new MenuItem();
            item5.name = "Tuna";
            item5.price = 7.50m;
            item5.quantity = 2;

            Dictionary<string, MenuItem> items = new Dictionary<string, MenuItem>();
            items.Add("Turkey", item1);
            items.Add("Ham", item2);
            items.Add("Chicken", item3);
            items.Add("Steak", item4);
            items.Add("Tuna", item5);


            Dictionary<string, string> actions = new Dictionary<string, string>();
            actions.Add("AddItem   ", "A");
            actions.Add("RemoveItem", "R");
            actions.Add("ChangeItem", "C");
            actions.Add("SellItem  ", "S");
            actions.Add("Quit      ", "Q");


            Console.WriteLine("Welcome to our Deli!");

            // Prints out the entire item menu and prices
            Console.WriteLine("Here are our menu items and their prices:");
            foreach (var pair in items)
            {
                Console.WriteLine($" {pair.Value.name} ${pair.Value.price} Quantity On Hand: {pair.Value.quantity}");
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
                } while (choice != "a" && choice != "r" && choice != "c" && choice != "s" && choice != "q");


                if (choice == "a")
                {
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

                        Console.Write("Enter the item quantity: ");
                        string quantityStr = Console.ReadLine();
                        int AddQuantity;
                        int.TryParse(quantityStr, out AddQuantity);
                        MenuItem AddItem = new MenuItem();
                        AddItem.name = food;
                        AddItem.price = itemPrice;
                        AddItem.quantity = AddQuantity;
                        items[food] = AddItem;

                        Console.WriteLine("\nHere are our updated menu items and their prices:");
                        foreach (var pair in items)
                        {
                            Console.WriteLine($" {pair.Value.name} ${pair.Value.price} Quantity On Hand: {pair.Value.quantity}");
                            menuCancel = false;     // Changed so that it breaks out of the while menuCancel loop
                        }
                    }
                }
                else if (choice == "r")
                {
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
                            Console.WriteLine($" {pair.Value.name} ${pair.Value.price} Quantity On Hand: {pair.Value.quantity}");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop
                        }
                    }
                }

                else if (choice == "c")
                {
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
                            Console.WriteLine($"This is the current price: ${items[chgfood].price}");
                            Console.Write("Enter the item's new price: $");
                            string newPrice = Console.ReadLine();
                            decimal itemNewPrice;
                            decimal.TryParse(newPrice, out itemNewPrice);
                            items[chgfood].price = itemNewPrice;
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
                            Console.WriteLine($" {pair.Value.name} ${pair.Value.price} Quantity On Hand: {pair.Value.quantity}");
                            menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop
                        }
                    }
                }
                else if (choice == "s")
                {
                    Console.WriteLine("\nYou chose to sell a menu item.");

                    string Sellfood = "";
                    string HowManyStr = "";
                    int howMany;
                    bool tryAgain = true;
                    //bool menuCancel = true;
                    while (tryAgain)
                    {
                        Console.Write("Enter the menu item to sell (or type CANCEL to return to the main menu): ");
                        Sellfood = Console.ReadLine();
                                               
                        if (Sellfood == "CANCEL")       // Checks if the user entered CANCEL >>>go back to top menu and prompt for new choice
                        {
                            Console.WriteLine("You chose to Cancel this action and start again.");
                            //menuCancel = false;     // Changed so that it breaks out of the while {menuCancel loop below
                            tryAgain = false;       // Changed so that it breaks out of the while {tryAgain loop
                        }
                        //else if (howMany > )   // Checks if the item doesn't exist in Dictionary and repeats if not there
                        //{
                        //    Console.WriteLine("Sorry that item doesn't exist. Please try again.");
                        //}
                        else if (!items.ContainsKey(Sellfood))   // Checks if the item doesn't exist in Dictionary and repeats if not there
                        {
                            Console.WriteLine("Sorry that item doesn't exist. Please try again.");
                        }
                        else
                        {
                            tryAgain = false;
                        }
                    }

                    bool OnceAgain = true;
                    bool CancelMenu = true;

                    while (OnceAgain)
                    {
                        Console.Write("Enter how many to sell (or type CANCEL to return to the main menu): ");
                        HowManyStr = Console.ReadLine();
                        int.TryParse(HowManyStr, out howMany);

                        if (HowManyStr == "CANCEL")       // Checks if the user entered CANCEL >>>go back to top menu and prompt for new choice
                        {
                            Console.WriteLine("You chose to Cancel this action and start again.");
                            CancelMenu = false;     // Changed so that it breaks out of the while {menuCancel loop below
                            OnceAgain = false;       // Changed so that it breaks out of the while {tryAgain loop
                        }
                        else if (howMany == 0)   // Checks if howMany beaing requested is > 0
                        {
                            Console.WriteLine("Sorry, the quantity requested must be greater than 0. Please try again.");
                        }
                        else if (howMany > items[Sellfood].quantity)   // Checks if the requested quantity is greater than in Dictionary and repeats if not enough on hand
                        {
                            Console.WriteLine("Sorry, the quantity requested is more than we have on-hand to sell. Please try again.");
                        }
                        else
                        {
                            OnceAgain = false;
                        }
                    }

                    while (CancelMenu)
                    {
                        items[Sellfood].Sell(howMany);
                        

                        if (items[Sellfood].quantity == 0)
                        {
                            items.Remove(Sellfood);      //Removes the item since action wasn't cancelled and it was determined to exist in dictionary
                        }
                        else
                        {
                            Console.WriteLine("\nHere is our updated menu items and their prices:");
                        foreach (var pair in items)
                        {
                                Console.WriteLine($" {pair.Value.name} ${pair.Value.price} Quantity On Hand: {pair.Value.quantity}");
                                CancelMenu = false;     // Changed so that it breaks out of the while {menuCancel loop
                        }
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
