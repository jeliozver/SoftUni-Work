using System;

namespace _02_Choreography
{
    class Choreography
    {
        static void Main(string[] args)
        {
            double stepsCount = double.Parse(Console.ReadLine());
            double dancersCount = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling(((stepsCount / days) / stepsCount) * 100);
            double percentPerDancer = stepsPerDay / dancersCount;

            if (stepsPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentPerDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! " +
                    $"Required {percentPerDancer:f2}% steps to be learned per day.");
            }
        }
    }
}