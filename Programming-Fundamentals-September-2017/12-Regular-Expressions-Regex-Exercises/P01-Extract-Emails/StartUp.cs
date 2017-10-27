namespace P01_Extract_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$";

            string[] text = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var validEmails = new List<string>();

            foreach (var word in text)
            {
                bool isDigit = word[0] >= 48 && word[0] <= 57;
                bool isUppercase = word[0] >= 65 && word[0] <= 90;
                bool isLowercase = word[0] >= 97 && word[0] <= 122;

                if (isDigit || isUppercase || isLowercase)
                {
                    string result = word.TrimEnd('.', ',', '!', '?', ':', '…');
                    var emailMatch = Regex.Match(result, pattern);

                    if (emailMatch.ToString() != string.Empty)
                    {
                        validEmails.Add(emailMatch.ToString());
                    }
                }
            }

            foreach (var email in validEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}