using System;

namespace PB_July_2016_1_Money
{
    class money
    {
        static void Main(string[] args)
        {
            var bitcoins = decimal.Parse(Console.ReadLine());
            var yuans = decimal.Parse(Console.ReadLine());
            var commissionPercent = decimal.Parse(Console.ReadLine());

            var leva = 1.76m * (0.15m * yuans);
            var recieve = (bitcoins * 1168 + leva) / 1.95m;
            var comissionValue = (commissionPercent / 100) * recieve;

            Console.WriteLine(Math.Round(recieve - comissionValue, 2));
        }
    }
}
