using System;

namespace _03_Final_Competition
{
    class FinalCompetition
    {
        static void Main(string[] args)
        {
            double dancersCount = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double money = 0;
            double moneyAbroad = 0;
            double expences = 0;
            double charityMoney = 0;
            double dancersMoney = 0;

            if (season == "summer")
            {
                if (place == "Bulgaria")
                {
                    money = points * dancersCount;
                    expences = money - (money * 0.05);
                }
                else if (place == "Abroad")
                {
                    money = dancersCount * points;
                    moneyAbroad += money + (money / 2);
                    expences = moneyAbroad - (moneyAbroad * 0.10);
                }

            }
            else if (season == "winter")
            {
                if (place == "Bulgaria")
                {
                    money = points * dancersCount;
                    expences = money - (money * 0.08);
                }
                else if (place == "Abroad")
                {
                    money = dancersCount * points;
                    moneyAbroad += money + (money / 2);
                    expences = moneyAbroad - (moneyAbroad * 0.15);
                }
            }

            charityMoney = expences * 0.75;
            double moneyLeft = expences - charityMoney;
            dancersMoney = moneyLeft / dancersCount;

            Console.WriteLine($"Charity - {charityMoney:f2}");
            Console.WriteLine($"Money per dancer - {dancersMoney:f2}");
        }
    }
}