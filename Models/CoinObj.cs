using System;

namespace CoinCalculator.Models
{
    public class ChangeCalculator
    {
        // public static int Quarters { get; set; }
        // public static int Dimes { get; set; }
        // public static int Nickles { get; set; }

        public static int Quarters = 25;
        public static int Dimes = 10;
        public static int Nickles = 5;
        public static int Pennys = 1;

        public static int MoneyLeft;

        // public static int MoneyLeftDimes;

        // public static int MoneyLeftNickles;






        // public static int Pennys { get; set; }

        public static int QuarterCalculator(int userInput)
        {
            int QuarterResult = userInput / Quarters;
            MoneyLeft = userInput % Quarters;
            return QuarterResult;

        }
        public static int DimeCalculator()
        {
            int DimesResult = MoneyLeft / Dimes;
            MoneyLeft = MoneyLeft % Dimes;
            return DimesResult;
        }

        public static int NicklesCalculator()
        {
            int NickleResult = MoneyLeft / Nickles;
            MoneyLeft = MoneyLeft % Nickles;
            return NickleResult;
        }

        public static int GetPenny()
        {
            return MoneyLeft;
        }
    }


}