using System;

namespace PB_June_2017_2_Swimming_World_Record
{
    class SwimmingWorldRecord
    {
        static void Main(string[] args)
        {
            decimal record = decimal.Parse(Console.ReadLine());
            decimal lenght = decimal.Parse(Console.ReadLine());
            decimal secondsPerMeter = decimal.Parse(Console.ReadLine());

            decimal timeSwim = lenght * secondsPerMeter;
            decimal delay = Math.Floor((lenght / 15m)) * 12.5m;
            decimal totalSwimTime = timeSwim + delay;

            if (totalSwimTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSwimTime:f2} seconds.");
            }
            else
            {
                decimal secondsSlower = totalSwimTime - record;
                Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
            }
        }
    }
}