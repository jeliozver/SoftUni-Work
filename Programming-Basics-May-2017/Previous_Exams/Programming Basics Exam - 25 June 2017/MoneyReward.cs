using System;

namespace PB_June_2017_4_Money_Reward
{
    class MoneyReward
    {
        static void Main(string[] args)
        {
            int projects = int.Parse(Console.ReadLine());
            double pricePerPoint = double.Parse(Console.ReadLine());

            int pointsSum = 0;

            for (int i = 1; i <= projects; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    pointsSum += points * 2;
                }
                else
                {
                    pointsSum += points;
                }
            }

            double projectPrice = pointsSum * pricePerPoint;

            Console.WriteLine($"The project prize was {projectPrice:f2} lv.");
        }
    }
}