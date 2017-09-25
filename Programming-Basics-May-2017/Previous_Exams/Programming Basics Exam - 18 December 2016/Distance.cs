using System;

namespace PB_Dec_2016_1_Distance
{
    class distance
    {
        public static void Main(string[] args)
        {
            double initialSpeed = double.Parse(Console.ReadLine());
            double fasterSpeedMinutes = double.Parse(Console.ReadLine());
            double slowerSpeedMinutes = double.Parse(Console.ReadLine());
            double remainingSpeedMinutes = double.Parse(Console.ReadLine());

            double initialSpeedHours = fasterSpeedMinutes / 60;
            double fasterSpeedHours = slowerSpeedMinutes / 60;
            double slowerSpeedHours = remainingSpeedMinutes / 60;

            double fasterSpeed = initialSpeed + (initialSpeed * 0.10);
            double slowerSpeed = fasterSpeed - (fasterSpeed * 0.05);

            double distanceInitialSpeed = initialSpeed * initialSpeedHours;
            double distanceFasterSpeed =  fasterSpeed * fasterSpeedHours;
            double distanceSlowerSpeed = slowerSpeed * slowerSpeedHours;
            double distanceTotal = distanceInitialSpeed + distanceFasterSpeed + distanceSlowerSpeed;

            Console.WriteLine("{0:F2}", distanceTotal);
        }
    }
}