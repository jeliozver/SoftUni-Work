namespace P02_Odd_Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            decimal[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToArray();

            List<decimal> oddsRemoved = numbers
                .Where(number => number % 2 == 0)
                .ToList();

            List<decimal> evensToOdds = new List<decimal>();

            foreach (var number in oddsRemoved)
            {
                if (number > oddsRemoved.Average())
                {
                    evensToOdds.Add(number + 1);
                }
                else if (number <= oddsRemoved.Average())
                {
                    evensToOdds.Add(number - 1);
                }
            }

            Console.WriteLine(string.Join(" ", evensToOdds));
        }
    }
}