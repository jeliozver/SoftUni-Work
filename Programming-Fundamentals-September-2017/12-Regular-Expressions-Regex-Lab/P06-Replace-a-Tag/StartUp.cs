namespace P06_Replace_a_Tag
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            var result = new List<string>();

            string htmlCode = Console.ReadLine();

            while (htmlCode != "end")
            {
                bool containsValidDate = Regex.IsMatch(htmlCode, pattern);

                if (containsValidDate)
                {
                    string replace = @"[URL href=$1]$2[/URL]";
                    string replaced = Regex.Replace(htmlCode, pattern, replace);
                    result.Add(replaced);
                }
                else
                {
                    result.Add(htmlCode);
                }

                htmlCode = Console.ReadLine();
            }

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }
        }
    }
}