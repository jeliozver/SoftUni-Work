namespace P04_Population_Aggregation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string info = Console.ReadLine();

            var countryCityCount = new SortedDictionary<string, int>();
            var populationByCity = new Dictionary<string, long>();
            var pattern = new Regex(@"[0-9$&@#]+"); ;

            while (info != "stop")
            {
                string[] args = info
                    .Split('\\')
                    .ToArray();

                string country = string.Empty;
                string city = string.Empty;
                long population = long.Parse(args[2]);

                if (args[0][0] >= 65 && args[0][0] <= 90)
                {
                    country = args[0];
                    city = args[1];
                }
                else
                {
                    country = args[1];
                    city = args[0];
                }

                string countryNameClean = pattern.Replace(country, "");
                string cityNameClean = pattern.Replace(city, "");

                if (!countryCityCount.ContainsKey(countryNameClean))
                {
                    countryCityCount[countryNameClean] = 0;
                }

                countryCityCount[countryNameClean]++;

                if (!populationByCity.ContainsKey(cityNameClean))
                {
                    populationByCity[cityNameClean] = 0L;
                }

                populationByCity[cityNameClean] = population;

                info = Console.ReadLine();
            }

            foreach (var kvp in countryCityCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            foreach (var city in populationByCity
                .OrderByDescending(p => p.Value)
                .Take(3))
            {
                Console.WriteLine($"{city.Key} -> {city.Value}");
            }
        }
    }
}