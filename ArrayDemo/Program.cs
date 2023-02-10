using System;

namespace ArrayDemo
{
    class Program
    {

        static decimal Average(decimal[] numbers)
        {
            decimal result = 0;
            // We can either do
            //  i <= numbers.Length - 1
            // or i < numbers.Length
            // Either is fine. They're the same
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result += numbers[i];
            }
            result = result / numbers.Length;
            return result;
        }

        static void Main(string[] args)
        {
            // An array of slots. Each slot holds a decimal. "An array of decimals."
            decimal[] prices = { 12.00m, 10.00m, 13.50m, 6.99m, 12.05m, 19.99m };

            // Calculate the average. First the hard way
            decimal avg = (prices[0] + prices[1] + prices[2] + prices[3] + prices[4] + prices[5]) / 6;
            Console.WriteLine(avg);

            // Better way.
            decimal realavg = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                // Test code
                //Console.WriteLine(prices[i]);

                realavg = realavg + prices[i];
            }
            realavg = realavg / prices.Length;
            Console.WriteLine(realavg);

            // Try out the function
            Console.WriteLine(Average(prices));
        }
    }
}
