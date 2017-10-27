namespace P06_Email_Statistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            int emailsCount = int.Parse(Console.ReadLine());

            string validEmailPattern = @"\b([A-Za-z]{5,})@([a-z]{3,}\.(bg|com|org))\b";

            var validEmails = new Dictionary<string, List<string>>();

            for (int i = 0; i < emailsCount; i++)
            {
                string currentEmail = Console.ReadLine();

                if (Regex.IsMatch(currentEmail, validEmailPattern))
                {
                    var currentMatch = Regex.Match(currentEmail, validEmailPattern);

                    string currentUser = currentMatch.Groups[1].Value;
                    string currentDomain = currentMatch.Groups[2].Value;

                    if (!validEmails.ContainsKey(currentDomain))
                    {
                        validEmails[currentDomain] = new List<string>();
                    }

                    if (!validEmails[currentDomain].Contains(currentUser))
                    {
                        validEmails[currentDomain].Add(currentUser);
                    }
                }
            }

            foreach (var domain in validEmails.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");

                foreach (var user in domain.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}