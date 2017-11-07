namespace P03_Anonymous_Vox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string encryptedString = Console.ReadLine();
            var placeholders = Console.ReadLine()
                .Split('{', '}')
                .Where(s => s != string.Empty)
                .ToList();

            string pattern = @"([A-Za-z]+)([\x00-\xFF]+)\1";

            var stringMatches = Regex.Matches(encryptedString, pattern);

            var matches = new List<string>();
            int replacings = 0;

            foreach (Match match in stringMatches)
            {
                if (replacings == placeholders.Count)
                {
                    break;
                }

                string currentMatch = match.Groups[2].Value;
                replacings++;

                matches.Add(currentMatch);
            }

            for (int i = 0; i < matches.Count; i++)
            {
                encryptedString = ReplaceFirstOccurrence(encryptedString, matches[i], placeholders[i]);
            }

            Console.WriteLine(encryptedString);
        }

        public static string ReplaceFirstOccurrence(string str, string match, string replace)
        {
            int first = str.IndexOf(match);
            string result = str.Remove(first, match.Length).Insert(first, replace);
            return result;
        }
    }
}