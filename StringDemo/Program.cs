using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ASCII - All characters take up 1 byte. But we're limited to 255 different characters.
            // UTF8 - Usual characters like what we typically type into a file like this one
            //        Take up one byte. All other characters such umlauts take up two bytes
            //        Chinese characters take up two bytes. Emojis take up two bytes.
            // Unicode - All characters take two bytes.
            // Of these three choices, UTF8 is the most commonly used one on the web
            // C# and .NET however use Unicode.

            string animal = "Horse"; // Ten bytes of memory -- but animal is five characters in length
            string animal2 = "Cow";  // Six bytes of memory -- but animal2 is three characters in length

            // In C#, every variable has a list of things it can do
            // That is, every variable has methods.
            // Noun.Verb    or   Noun.Property

            // I want to know how long the string in animal is.

            Console.WriteLine(animal.Length);
            Console.WriteLine(animal2.Length);

            int size1 = animal.Length;
            Console.WriteLine(size1);

            Console.WriteLine(animal[4]);  // The index is one less than the natural ordinal number

            // Try changing the < to <= and NOTE THE ERROR MESSAGE.
            for (int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine(animal[i]);
            }

            /*Console.WriteLine("\nHow about some Chinese?");
            //Console.OutputEncoding = Enco
            string ch1 = "你们会说中文吗？";
            Console.WriteLine(new string (ch1));*/

            //Let's try changing a string. Change "Cow" to "Bow"
            // The first letter needs to be changed from C to B

            Console.WriteLine("\nChanging strings");
            // Strings cannot be changed. They are "immutable".
            //animal2[0] = "B";  This didn;t work. It didn't let us change the letter!!!
            Console.WriteLine(animal2);
            animal2 = "Bow";
            Console.WriteLine(animal2);  // This seemed to work. Hmmmmm......

            // Now let's make Bow into lowercase
            Console.WriteLine(animal2.ToLower());
            Console.WriteLine(animal2.ToUpper());
            Console.WriteLine(animal2);
            animal2.ToUpper();  // Nothing happened! And the compiler did NOT yell at me.
            Console.WriteLine(animal2);  //We can see nothing happened!
            animal2 = animal2.ToUpper();  // This one "changes" it but really replaced it with a new one that's uppercase
            Console.WriteLine(animal2); // Now it really is different
        }
    }
}
