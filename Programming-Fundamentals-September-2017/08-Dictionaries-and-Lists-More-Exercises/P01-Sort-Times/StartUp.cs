namespace P01_Sort_Times
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            SortedDictionary<string, int> sortedHours = new SortedDictionary<string, int>();

            string[] unsortedHours = Console.ReadLine()
                .Split(' ')
                .ToArray();

            foreach (var hour in unsortedHours)
            {
                if (!sortedHours.ContainsKey(hour))
                {
                    sortedHours[hour] = 0;
                }

                sortedHours[hour]++;
            }

            List<string> sortedHoursList = sortedHours
                .Select(hour => hour.Key)
                .ToList();

            Console.WriteLine(string.Join(", ", sortedHoursList));
        }
    }
}