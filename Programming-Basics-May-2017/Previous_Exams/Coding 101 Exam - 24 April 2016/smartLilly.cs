using System;

namespace PB_April_2016_4_Smart_Lilly
{
    class smartLilly
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double toysCount = 0.0;
            double toysMoney = 0.0;

            double giftMoney = 10.00;
            double giftMoneyTotal = 0.00;

            double moneyTotal = 0.0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    giftMoneyTotal += giftMoney;
                    giftMoneyTotal -= 1.00;
                    giftMoney += 10.00;
                }
                else
                {
                    toysCount++;
                }
            }

            toysMoney = toysCount * toyPrice;
            moneyTotal = giftMoneyTotal + toysMoney;

            if (moneyTotal >= washMachinePrice)
            {
                Console.WriteLine("Yes! {0:f2}", Math.Abs(moneyTotal - washMachinePrice));
            }
            else
            {
                Console.WriteLine("No! {0:f2}", Math.Abs(moneyTotal - washMachinePrice));
            }
        }
    }
}
