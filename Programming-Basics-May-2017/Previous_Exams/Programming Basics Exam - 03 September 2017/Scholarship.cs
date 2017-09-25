using System;

namespace PB_Sep_2017_2_Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double mark = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            double socialScholarshipGain = 0.00;
            double excellentScholarshipGain = 0.00;

            if (income < minimalWage && mark > 4.50)
            {
                socialScholarshipGain = minimalWage * 0.35;
                if (mark >= 5.50)
                {
                    excellentScholarshipGain = mark * 25;
                }
                if (socialScholarshipGain > excellentScholarshipGain)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarshipGain)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarshipGain)} BGN");
                }
            }
            else if (mark >= 5.50)
            {
                excellentScholarshipGain = mark * 25;
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarshipGain)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}