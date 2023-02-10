using System;

namespace Lab3_1_JeffVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Fred", "Julie", "Sam", "Sally", "Harry" };
            string[] food = { "Steak", "Pizza", "Fried Chicken", "Veggie Burgers", "Popcorn" };
            string[] titles = { "Developer", "Lead Developer", "IT", "Accountant", "IT Repair" };


            bool numOK = false;
            int stnum = 0;
            while (numOK == false)
            {
                // Don't hard-code the lengths of the arrays. Instead, *ask* the array for it's length: names.Length.
                Console.WriteLine($"Which student would you like to learn about? Enter a number 1-{names.Length}");
                 string student = Console.ReadLine();
                 //stnum = int.Parse(student) -1;
                 if (int.TryParse(student, out stnum))
                 {
                     // If we get here, that means they typed in a valid number
                     // But now we need to check if the number is in the correct range.
                     if (stnum >= 1 && stnum <= names.Length)
                     {
                        // Now the entry is valid. Flip numOK to true so we can get out the the loop
                        stnum = stnum - 1;
                        numOK = true;
                     }
                     else
                     {
                          Console.WriteLine("Although that's a number, we don't have a student with that number.");
                     }
                 }
                 else
                 {
                     // It wasn't a number at all
                     Console.WriteLine($"That isn't a number. Please enter a number 1-{names.Length}.");
                 }
            }

            Console.WriteLine($"Student {stnum + 1} is {names[stnum]}");
            

            bool categoryOK = false;
            while (categoryOK == false)
            {
                // Don't hard-code the lengths of the arrays. Instead, *ask* the array for it's length: names.Length.
                Console.WriteLine($"What would you like to know about {names[stnum]}? Choose \"food\" or \"title\"");
                string choice = Console.ReadLine();

                if (choice == "food")
                {
                Console.WriteLine($"{names[stnum]}'s favorite food is {food[stnum]}");
                    categoryOK = true;
                }
                else if (choice == "title")
                {
                Console.WriteLine($"{names[stnum]}'s title is {titles[stnum]}");
                    categoryOK = true;
                }
                else
                {
                Console.WriteLine("Sorry that is not a category.");
                }
            }

            Console.WriteLine("Thank you for playing.");
        }
    }
}
