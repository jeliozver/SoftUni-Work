namespace P07_Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string currentInput = Console.ReadLine();

            string patern = @"([^&=?]*)=([^&=]*)";
            string trimPattern = @"((%20|\+)+)";
          
            while (currentInput != "END")
            {
                var matches = Regex.Matches(currentInput, patern);
                var result = new Dictionary<string, List<string>>();

                foreach (Match match in matches)
                {
                    string field = match.Groups[1].Value;
                    field = Regex.Replace(field, trimPattern, word => " ")
                        .Trim();

                    string value = match.Groups[2].Value;
                    value = Regex.Replace(value, trimPattern, word => " ")
                        .Trim();

                    if (!result.ContainsKey(field))
                    {
                        result[field] = new List<string>();
                    }

                    result[field].Add(value);
                }

                foreach (var pair in result)
                {
                    Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
                }

                Console.WriteLine();

                currentInput = Console.ReadLine();
            }
        }
    }
}