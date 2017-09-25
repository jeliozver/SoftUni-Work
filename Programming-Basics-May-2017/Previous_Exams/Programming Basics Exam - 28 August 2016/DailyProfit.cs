using System;

namespace PB_Aug_2016_1_Daily_Profit
{
    class dailyProfit
    {
        static void Main(string[] args)
        {
            decimal workDays = decimal.Parse(Console.ReadLine());
            decimal moneyDaily = decimal.Parse(Console.ReadLine());
            decimal usdRate = decimal.Parse(Console.ReadLine());

            decimal monthlyProfit = workDays * moneyDaily;
            decimal bonus = monthlyProfit * 2.5m;
            decimal yearProfit = (monthlyProfit * 12) + bonus;
            decimal taxPercentage = 25;
            decimal profitAfterTaxInLeva = (yearProfit - (taxPercentage / 100) * yearProfit) * usdRate;
            decimal dailyAverage = profitAfterTaxInLeva / 365;

            Console.WriteLine("{0:F2}", dailyAverage);
        }
    }
}
