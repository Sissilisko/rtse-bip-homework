using System;

namespace exercise_126
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Try your code here, if you want
            PaymentTerminal lunchCafeteria = new PaymentTerminal();

            double change = lunchCafeteria.DrinkCoffee(0);
            Console.WriteLine("remaining change " + change);

            change = lunchCafeteria.DrinkCoffee(2);
            Console.WriteLine("remaining change " + change);

            change = lunchCafeteria.EatLunch(10);
            Console.WriteLine("remaining change " + change);

            Console.WriteLine(lunchCafeteria);
        }
    }
}