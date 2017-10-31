namespace P01_Hornet_Wings
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            decimal distanceInMetersPerThousandFlaps = decimal.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            if (endurance == 0)
            {
                Console.WriteLine("0.00 m.");
                Console.WriteLine("0 s.");
                return;
            }

            int wingFlapsTime = wingFlaps / 100;
            ulong restTime = (ulong)wingFlaps / (ulong)endurance * 5UL;

            decimal distance = wingFlaps / 1000.00m * distanceInMetersPerThousandFlaps;
            ulong totalTime = (ulong)wingFlapsTime + restTime;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}