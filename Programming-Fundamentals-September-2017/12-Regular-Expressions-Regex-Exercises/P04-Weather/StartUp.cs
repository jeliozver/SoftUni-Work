namespace P04_Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string currentReport = Console.ReadLine();

            var weatherReportByCity = new Dictionary<string, WeatherReport>();
            string pattern = @"([A-Z]{2})(\d{1,2}\.\d{1,2})([A-Za-z]+)\|";

            while (currentReport != "end")
            {
                if (Regex.IsMatch(currentReport, pattern))
                {
                    var validReport = Regex.Match(currentReport, pattern);

                    string currentCity = validReport.Groups[1].Value;
                    double currentTemp = double.Parse(validReport.Groups[2].Value);
                    string currentWeather = validReport.Groups[3].Value;

                    var cityReport = new WeatherReport();

                    if (!weatherReportByCity.ContainsKey(currentCity))
                    {
                        weatherReportByCity[currentCity] = cityReport;
                    }

                    cityReport.Name = currentCity;
                    cityReport.AverageTemp = currentTemp;
                    cityReport.WeatherType = currentWeather;

                    weatherReportByCity[currentCity] = cityReport;
                }

                currentReport = Console.ReadLine();
            }

            var reportSorted = weatherReportByCity
                .Values
                .OrderBy(avg => avg.AverageTemp);

            foreach (var city in reportSorted)
            {
                Console.WriteLine($"{city.Name} => " +
                                  $"{city.AverageTemp:f2} => " +
                                  $"{city.WeatherType}");
            }
        }
    }
}