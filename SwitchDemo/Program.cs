using System;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 1 to 4: ");
            string entry = Console.ReadLine();

           if (entry == "1" || entry == "one")
            {
                Console.WriteLine("You entered ONE");
            }
            else if (entry == "2")
            {
                Console.WriteLine("You entered TWO");
            }
            else if (entry == "3")
            {
                Console.WriteLine("You entered THREE");
            }
            else if (entry == "4")
            {
                Console.WriteLine("You entered FOUR");
            }
            else
            {
                Console.WriteLine("You entered something else");
            }
            
            switch (entry)
            {
                case "1":
                    Console.WriteLine("You entered ONE");
                    break;
                case "2":
                    Console.WriteLine("You entered TWO");
                    break;
                case "3":
                    Console.WriteLine("You entered THREE");
                    break;
                case "4":
                    Console.WriteLine("You entered FOUR");
                    break;
                default:
                    Console.WriteLine("You entered something else");
                    break;
            }
        }
    }
}
