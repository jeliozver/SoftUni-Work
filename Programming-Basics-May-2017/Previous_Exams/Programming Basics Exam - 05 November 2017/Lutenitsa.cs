namespace PB_November_2017_2_Lutenitsa
{
    using System;

    public class Lutenitsa
    {
        public static void Main()
        {
            double tomatoesAmount = double.Parse(Console.ReadLine());
            int boxesCount = int.Parse(Console.ReadLine());
            int jarsCount = int.Parse(Console.ReadLine());

            double totalLutenitca = tomatoesAmount / 5;
            double jars = totalLutenitca / 0.535;
            double boxes = jars / jarsCount;

            Console.WriteLine($"Total lutenica: {Math.Floor(totalLutenitca)} kilograms.");

            if (boxes >= boxesCount)
            {
                double boxesLeft = Math.Floor(boxes - boxesCount);
                double jarsLeft = Math.Floor(jars - boxesCount * jarsCount);

                Console.WriteLine($"{boxesLeft} boxes left.");
                Console.WriteLine($"{jarsLeft} jars left.");
            }
            else
            {
                double boxesNeed = Math.Floor(boxesCount - boxes);
                double jarsNeed = Math.Floor(boxesCount * jarsCount - jars);

                Console.WriteLine($"{boxesNeed} more boxes needed.");
                Console.WriteLine($"{jarsNeed} more jars needed.");
            }
        }
    }
}