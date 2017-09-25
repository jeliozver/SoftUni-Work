using System;

namespace PB_July_2016_4_Back_to_the_Past
{
    class back2Past
    {
        static void Main(string[] args)
        {
            double moneyTotal = double.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());

            double yearsToCalc = year - 1799;
            double evenYearsSpent = 0;
            double oddYearsSpent = 0;
            double age = 17;


            for (int i = 0; i < yearsToCalc; i++)
            {
                age++;
				
                if (i % 2 == 0)
                {
                    evenYearsSpent += 12000;
                }
                else
                {
                    oddYearsSpent += 12000 + (50 * age);
                }
            }

            double totalSpent = evenYearsSpent + oddYearsSpent;

            if (moneyTotal >= totalSpent)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", 
                    Math.Abs(moneyTotal - totalSpent));
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", 
                    Math.Abs(moneyTotal - totalSpent));
            }
        }
    }
}
