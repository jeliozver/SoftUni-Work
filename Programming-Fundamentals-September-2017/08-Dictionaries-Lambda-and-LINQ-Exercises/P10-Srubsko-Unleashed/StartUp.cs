using System.Linq;

namespace P10_Srubsko_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            const string pattern = @"(.*?) @(.*?) (\d+) (\d+)";

            var report = new Dictionary<string, Dictionary<string, long>>();

            string data = Console.ReadLine();

            while (data != "End")
            {
                if (!Regex.IsMatch(data, pattern))
                {
                    data = Console.ReadLine();
                    continue;
                }

                var match = Regex.Match(data, pattern);
                string singer = match.Groups[1].Value;
                string venue = match.Groups[2].Value;
                int ticketPrice = int.Parse(match.Groups[3].Value);
                int ticketCount = int.Parse(match.Groups[4].Value);

                long totalMoney = (long)ticketCount * ticketPrice;

                if (!report.ContainsKey(venue))
                {
                    report.Add(venue, new Dictionary<string, long>());
                }

                if (!report[venue].ContainsKey(singer))
                {
                    report[venue].Add(singer, 0);
                }

                report[venue][singer] += totalMoney;

                data = Console.ReadLine();
            }

            foreach (var venue in report)
            {
                Console.WriteLine($"{venue.Key}");

                var earningsSorted = report[venue.Key].OrderByDescending(x => x.Value);

                foreach (var singer in earningsSorted)
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}