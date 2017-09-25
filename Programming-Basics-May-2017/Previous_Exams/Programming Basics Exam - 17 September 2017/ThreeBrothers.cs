using System;

namespace PB_Sep_2_2017_2_Three_Brothers
{
    class ThreeBrothers
    {
        static void Main(string[] args)
        {
            double firstBrotherTime = double.Parse(Console.ReadLine());
            double secondBrotherTime = double.Parse(Console.ReadLine());
            double thirdBrotherTime = double.Parse(Console.ReadLine());
            double fishingTime = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / firstBrotherTime + 1 / secondBrotherTime + 1 / thirdBrotherTime);
            double timeWithBreak = totalTime + (totalTime * 0.15);
            double timeLeft = fishingTime - timeWithBreak;
            double timeRequired = timeWithBreak - fishingTime;

            Console.WriteLine($"Cleaning time: {timeWithBreak:f2}");

            if (timeLeft > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");
            }
            else
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(timeRequired)} hours.");
            }
        }
    }
}