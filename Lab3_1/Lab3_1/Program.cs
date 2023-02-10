using System;

namespace Lab3_1
{
    class Program
    {
        static bool contStud()
        {
            while (true)
            {
                Console.Write("\n\nWould you like to know about another student? (Enter 'yes' or 'no'): ");                        //Prompts for user input to continue or not
                string moreStud = Console.ReadLine();
                moreStud = moreStud.ToLower();                           //Converts input case to only lower case

                if (moreStud == "y" || moreStud == "yes")                //Checks the condition to continue measuring rooms or quit
                {
                    return true;
                }
                else if (moreStud == "n" || moreStud == "no")
                {
                    return false;
                }
                else
                {
                    Console.Write("Please enter only y or n!");                //Prompts user to only enter a y (yes ) or n (no) if another character is entered
                }
            }
        }
        static void Main(string[] args)
        {

            string[] names = { "Luke", "Han", "Lando", "Leia", "Chewbacca", "Darth" };
            string[] favFood = { "Lasagna", "Steak", "Chicken", "Vegan Buffet", "Pizza", "Ice Cream" };
            string[] prevTitle = { "Jedi Master in Training", "Scoundrel", "Smuggler", "Princess", "Co-Pilot", "Villain" };


            Console.WriteLine("Welcome to our DevBuild class.");
            do
            {
                bool rangeOk = false;
                int studIn = 0;

                while (rangeOk == false)
                {
                    Console.WriteLine("Which student would you like to learn more about?");
                    Console.Write($"Enter a number 1 - {names.Length}: ");
                    string entry = Console.ReadLine();

                    if (int.TryParse(entry, out studIn))
                    {
                        if (studIn >= 1 && studIn <= names.Length)
                        {
                            studIn = studIn - 1;
                            rangeOk = true;
                        }
                        else
                        {
                            Console.Write($"\nThat student number isn't in our list. Enter a number from 1 -{names.Length}: ");
                        }
                    }
                    else
                    {
                        Console.Write($"\nSorry, input has to be numeric. Please enter a number 1-{names.Length}.");
                    }
                }

                Console.WriteLine($"Student {studIn + 1} is {names[studIn]}");

                bool optionIn = false;
                while (optionIn == false)
                {
                    Console.Write($"What would you like to know about {names[studIn]}? (Please enter 'favorite food' or 'previous title'): ");

                    string moreInfo = Console.ReadLine().ToLower();

                    if (moreInfo == "favorite food" || moreInfo == "food")
                    {
                        Console.Write($"{names[studIn]}'s favorite food is {favFood[studIn]}.");
                        optionIn = true;
                    }
                    else if (moreInfo == "previous title" || moreInfo == "title")
                    {
                        Console.Write($"{names[studIn]}'s previous title was {prevTitle[studIn]}.");
                        optionIn = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is not a an option. Please try again.");
                    }
                }
            } while (contStud());

            Console.WriteLine("\nThanks for checking in with our class!");
        }

    }
}

