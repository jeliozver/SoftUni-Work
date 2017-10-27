namespace P06_Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string[] allUsers = inputLine
                .Split(new[] { ' ', '/', '\\', '(', ')' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string pattern = @"\b[A-Za-z](\w{1,23}[A-Z|a-z|0-9|_])\s";
            var validUsers = new List<string>();

            foreach (var user in allUsers)
            {
                var limiter = user + " ";
                if (!Regex.IsMatch(limiter, pattern)) continue;
                var validUser = Regex.Match(limiter, pattern);
                string validUserTrim = validUser.Value.TrimEnd(' ');
                validUsers.Add(validUserTrim);
            }

            int bestLenght = validUsers[0].Length + validUsers[1].Length;
            string userOne = validUsers[0];
            string userTwo = validUsers[1];

            for (int i = 1; i < validUsers.Count - 1; i++)
            {
                if (validUsers[i].Length + validUsers[i + 1].Length > bestLenght)
                {
                    bestLenght = validUsers[i].Length + validUsers[i + 1].Length;
                    userOne = validUsers[i];
                    userTwo = validUsers[i + 1];
                }
            }

            Console.WriteLine(userOne);
            Console.WriteLine(userTwo);
        }
    }
}