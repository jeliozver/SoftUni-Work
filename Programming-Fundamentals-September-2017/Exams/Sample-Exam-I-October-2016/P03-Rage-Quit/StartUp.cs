namespace P03_Rage_Quit
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var uniqueletters = new HashSet<string>();

            string pattern = @"([\D]+)(\d+)";

            var matches = Regex.Matches(input, pattern);

            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                string toRepeat = match.Groups[1].Value.ToUpper();
                int count = int.Parse(match.Groups[2].Value);

                result.Append(NewString(toRepeat, count));
            }

            foreach (char letter in result.ToString())
            {
                uniqueletters.Add(letter.ToString());
            }

            Console.WriteLine($"Unique symbols used: {uniqueletters.Count}");
            Console.WriteLine(result.ToString());
        }

        public static string NewString(string str, int count)
        {
            var body = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                body.Append(str);
            }

            return body.ToString();
        }
    }
}