namespace P02_Hornet_Comm
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
            var splitter = new Regex(@"\s{1}<->{1}\s{1}");
            string secondQuerryPattern = @"^[a-zA-Z0-9]+$";

            var broadcasts = new List<string>();
            var messages = new List<string>();

            string currentInput = Console.ReadLine();

            while (currentInput != "Hornet is Green")
            {
                string[] arguments = splitter
                    .Split(currentInput)
                    .ToArray();

                if (arguments.Length == 2)
                {
                    string firstQuerry = arguments[0];
                    string secondQuerry = arguments[1];

                    if (!IsDigitsOnly(firstQuerry) && Regex.IsMatch(secondQuerry, secondQuerryPattern))
                    {
                        string message = firstQuerry;
                        string frequency = ReverseLettersCases(secondQuerry);
                        string result = frequency + " -> " + message;

                        broadcasts.Add(result);
                    }
                    else if (IsDigitsOnly(firstQuerry) && Regex.IsMatch(secondQuerry, secondQuerryPattern))
                    {
                        string recipientCode = ReverseString(firstQuerry);
                        string message = secondQuerry;
                        string result = recipientCode + " -> " + message;

                        messages.Add(result);
                    }
                }

                currentInput = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine(broadcast);
                }
            }

            Console.WriteLine("Messages:");

            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
        }

        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
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

        public static string ReverseLettersCases(string str)
        {
            var builder = new StringBuilder();
            int diff = 32;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    char result = (char)(str[i] + diff);

                    builder.Append(result);
                }
                else if (str[i] >= 97 && str[i] <= 122)
                {
                    char result = (char)(str[i] - diff);

                    builder.Append(result);
                }
                else
                {
                    builder.Append(str[(char)i]);
                }
            }

            return builder.ToString();
        }
    }
}