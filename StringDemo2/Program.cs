using System;

namespace StringDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter some word: ");
            string entry = Console.ReadLine();

            Console.WriteLine("The entry backwards:");
            for (int i = entry.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(entry[i]);
            }

            // Let's create a variable called rev and put the reverse of entry into it.
            Console.WriteLine("\nLet's build a reverse string: ");
            string rev = "";
            //rev = rev + 'A';
            //rev = rev + 'B';
            for (int i = entry.Length - 1; i >=0; i--)
            {
                rev = rev + entry[i];
            }
            Console.WriteLine(rev);

        }
    }
}
