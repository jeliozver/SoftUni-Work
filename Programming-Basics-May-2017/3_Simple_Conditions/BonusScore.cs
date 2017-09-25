using System;

namespace Bonus_Score
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            double bonusScore = 0.0;

            if (num > 1000)
            {
                bonusScore = num * 0.10;
            }
            else if (num > 100)
            {
                bonusScore = num * 0.20;
            }
            else
            {
                bonusScore = 5;
            }

            if (num % 10 == 5)
            {
                bonusScore += 2;
            }
            else if (num % 2 == 0)
            {
                bonusScore += 1;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(num + bonusScore);
        }
    }
}
