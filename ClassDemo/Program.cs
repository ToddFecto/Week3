using System;

namespace ClassDemo
{
    class Pen
    {
        public string Color;
        public double InkAmount;
        public decimal Price;
        public void Draw()
        {
            InkAmount = InkAmount - 0.5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Pen mypen1 = new Pen();
            mypen1.Color = "Blue";
            mypen1.InkAmount = 3.0;
            mypen1.Price = 0.25m;

            Console.WriteLine($"mypen1 has color {mypen1.Color}, ink amount {mypen1.InkAmount}, price {mypen1.Price}");

            Pen mypen2 = new Pen();
            mypen2.Color = "Red";
            mypen2.InkAmount = 5.0;
            mypen2.Price = 0.50m;

            Console.WriteLine($"mypen2 has color {mypen2.Color}, ink amount {mypen2.InkAmount}, price {mypen1.Price}");

            mypen1.Draw();
            Console.WriteLine($"mypen1 has color {mypen1.Color}, ink amount {mypen1.InkAmount}, price {mypen1.Price}");
            Console.WriteLine($"mypen2 has color {mypen2.Color}, ink amount {mypen2.InkAmount}, price {mypen1.Price}");

        }
    }
}
