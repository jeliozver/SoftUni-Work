namespace P03_Football_League
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
            var league = new SortedDictionary<string, long>();
            var topGoals = new SortedDictionary<string, long>();

            string key = Console.ReadLine();
            string currentInfo = Console.ReadLine();

            string keyEscape = Regex.Escape(key);

            string pattern = $@"{keyEscape}(\w+){keyEscape}";

            while (currentInfo != "final")
            {
                string[] args = currentInfo
                    .Split(' ')
                    .ToArray();

                var teamOneEncrypted = Regex.Match(args[0], pattern);
                var teamTwoEncrypted = Regex.Match(args[1], pattern);

                string teamOne = ReverseString(teamOneEncrypted.Groups[1].Value).ToUpper();
                string teamTwo = ReverseString(teamTwoEncrypted.Groups[1].Value).ToUpper();

                string[] scores = args[2]
                .Split(':')
                .ToArray();

                int teamOneScore = int.Parse(scores[0]);
                int teamTwoScore = int.Parse(scores[1]);

                if (!league.ContainsKey(teamOne))
                {
                    league[teamOne] = 0L;
                }
                if (!league.ContainsKey(teamTwo))
                {
                    league[teamTwo] = 0L;
                }

                if (!topGoals.ContainsKey(teamOne))
                {
                    topGoals[teamOne] = 0L;
                }
                if (!topGoals.ContainsKey(teamTwo))
                {
                    topGoals[teamTwo] = 0L;
                }

                if (teamOneScore == teamTwoScore)
                {
                    league[teamOne] += 1;
                    league[teamTwo] += 1;
                }
                else if (teamOneScore > teamTwoScore)
                {
                    league[teamOne] += 3;
                }
                else if (teamTwoScore > teamOneScore)
                {
                    league[teamTwo] += 3;
                }

                topGoals[teamOne] += teamOneScore;
                topGoals[teamTwo] += teamTwoScore;

                currentInfo = Console.ReadLine();
            }

            int counter = 1;

            Console.WriteLine("League standings:");
            foreach (var team in league.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{counter}. {team.Key} {team.Value}");
                counter++;
            }

            counter = 0;

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in topGoals.OrderByDescending(a => a.Value))
            {
                if (counter == 3)
                {
                    break;
                }

                counter++;
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        public static string ReverseString(string stringToReverse)
        {
            var builder = new StringBuilder();

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                builder.Append(stringToReverse[i]);
            }

            string stringReversed = builder.ToString();

            return stringReversed;
        }
    }
}