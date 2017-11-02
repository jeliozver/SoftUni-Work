namespace P01_Charity_Marathon
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            short lenghtMarathonDays = short.Parse(Console.ReadLine());
            int runnersCount = int.Parse(Console.ReadLine());
            byte averageLapsPerRunner = byte.Parse(Console.ReadLine());
            int lapLenght = int.Parse(Console.ReadLine());
            short trackCapacity = short.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            int maximumRunnersCount = trackCapacity * lenghtMarathonDays;

            if (runnersCount > maximumRunnersCount)
            {
                runnersCount = maximumRunnersCount;
            }

            ulong totalMeters = (ulong)runnersCount * averageLapsPerRunner * (ulong)lapLenght;
            decimal totalKilometers = (decimal)totalMeters / 1000;
            decimal moneyRaised = totalKilometers * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}