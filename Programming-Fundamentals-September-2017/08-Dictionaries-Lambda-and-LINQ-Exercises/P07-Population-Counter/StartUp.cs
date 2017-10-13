namespace P07_Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var report = new Dictionary<string, Dictionary<string, long>>();

            string data = Console.ReadLine();

            while (data != "report")
            {
                string[] arguments = data.Split('|');
                string country = arguments[1];
                string city = arguments[0];
                int population = int.Parse(arguments[2]);

                if (!report.ContainsKey(country))
                {
                    report[country] = new Dictionary<string, long>();
                }

                if (!report[country].ContainsKey(city))
                {
                    report[country].Add(city, 0);
                }

                report[country][city] += population;

                data = Console.ReadLine();
            }

            var countriesSorted = report.OrderByDescending(x => x.Value.Sum(y => y.Value));

            foreach (var country in countriesSorted)
            {
                List<long> sum = country.Value.Select(x => x.Value).ToList();

                Console.WriteLine($"{country.Key} (total population: {sum.Sum()})");

                var citiesSorted = report[country.Key].OrderByDescending(x => x.Value);

                foreach (var city in citiesSorted)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}