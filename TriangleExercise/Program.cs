using System;

namespace TriangleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Triangle!");

            for (int row = 1; row <= 10; row++)
            {
                for (int indent = 1; indent <= 10 - row; indent++)
                {
                    Console.Write(" ");
                }
                for (int inner =1; inner <=row; inner++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
