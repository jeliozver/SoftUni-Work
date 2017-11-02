namespace P03_Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string healthPattern = @"[^\+\-\*\/\.\d]+";
            string damagePattern = @"(\+\d+\.\d+)|(\d+\.\d+)|(\d+)|(\-\d+\.\d+)|(\*)|(\/)|(\-\d+)|(\+\d+)";

            var demonsList = new SortedDictionary<string, List<decimal>>();

            string input = Console.ReadLine();

            string[] names = input
                .Split(new[] { ' ', ',' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var name in names)
            {
                var healthMatches = Regex.Matches(name, healthPattern);
                var damageMatches = Regex.Matches(name, damagePattern);

                var builder = new StringBuilder();

                foreach (Match match in healthMatches)
                {
                    builder.Append(match);
                }

                string health = builder.ToString();
                builder.Clear();

                foreach (Match match in damageMatches)
                {
                    builder.Append(match + " ");
                }

                string damage = builder.ToString().TrimEnd(' ');

                long healthSum = CalculateHealth(health);
                decimal damageSum = CalculateDamage(damage);

                if (!demonsList.ContainsKey(name))
                {
                    demonsList[name] = new List<decimal>();
                    demonsList[name].Add(healthSum);
                    demonsList[name].Add(damageSum);
                }
            }

            foreach (var demon in demonsList)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }

        public static long CalculateHealth(string health)
        {
            long sum = 0;

            foreach (char letter in health)
            {
                sum += letter;
            }

            return sum;
        }

        public static decimal CalculateDamage(string damage)
        {
            decimal sum = 0;

            string[] numbers = damage
                .Split(new[] { ' ', '/', '*' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string num in numbers)
            {
                sum += decimal.Parse(num);
            }

            var multiplyDivideSymbols = Regex.Matches(damage, @"\/|\*");

            foreach (Match match in multiplyDivideSymbols)
            {
                if (match.Value.Contains('*'))
                {
                    sum *= 2;
                }
                else if (match.Value.Contains('/'))
                {
                    sum /= 2;
                }
            }

            return sum;
        }
    }
}