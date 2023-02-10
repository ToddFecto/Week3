using System;

namespace StringReverse
{
    class Program
    {

        static string Reverse(string str)
        {
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            return rev;
        }

        static void Main(string[] args)
        {
            // test code
            //string test = "Hello";
            //string test2 = Reverse(test);
            //Console.WriteLine(test2);

            Console.WriteLine("Please enter some words");
            string entry = Console.ReadLine();

            // string test = Reverse(entry); Revised in the next line saying the same thing:
            Console.WriteLine(Reverse(entry));

            // get used to the code above -- calling a function and taking its
            //return value and immediately passing that value into another function
            // So what we have is a function call as a parameter.

            //An interesting exercise is to reverse the individual words of a sentence
            //e.g Hello World => olleH dlroW
            //e.g Hello     World => olleH     dlroW

        }
    }
}
