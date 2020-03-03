using System;
using CoinCalculator.Models;

namespace CoinCalculator
{
    public class Coin
    {
        static void Main()
        {

            Console.WriteLine("Enter a number");
            int.TryParse(Console.ReadLine(), out int cents);
            Console.WriteLine(cents);

            Console.WriteLine("Qurters are returned from your cents " + ChangeCalculator.QuarterCalculator(cents));
            Console.WriteLine("Dimes are returned from your cents " + ChangeCalculator.DimeCalculator());
            Console.WriteLine("Nickles are returned from your cents " + ChangeCalculator.NicklesCalculator());
            Console.WriteLine("Cents are Penny! " + ChangeCalculator.GetPenny());
        }

        static void Results()
        {



        }

    }
}