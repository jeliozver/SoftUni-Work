namespace P05_Key_Replacer
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();

            string startKey = GetStartKey(keyString);
            string endKey = GetEndKey(keyString);
            string matchPattern = $@"({startKey})(.*?)({endKey})";
            var matches = Regex.Matches(textString, matchPattern);
            string message = string.Empty;

            foreach (Match msg in matches)
            {
                message = string.Concat(message, msg.Groups[2].Value);
            }

            Console.WriteLine(message != string.Empty
                ? message
                : "Empty result");
        }

        public static string GetStartKey(string keyString)
        {
            var builder = new StringBuilder();

            foreach (char letter in keyString)
            {
                if (letter == '<' || letter == '|' || letter == '\\')
                {
                    break;
                }

                if (letter >= 97 && letter <= 122)
                {
                    builder.Append(letter);
                }
                else if (letter >= 65 && letter <= 90)
                {
                    builder.Append(letter);
                }
            }

            return builder.ToString();
        }

        public static string GetEndKey(string keyString)
        {
            var builder = new StringBuilder();

            string keyStringReversed = ReverseString(keyString);

            foreach (char letter in keyStringReversed)
            {
                if (letter == '<' || letter == '|' || letter == '\\')
                {
                    break;
                }

                if (letter >= 97 && letter <= 122)
                {
                    builder.Append(letter);
                }
                else if (letter >= 65 && letter <= 90)
                {
                    builder.Append(letter);
                }
            }

            string result = ReverseString(builder.ToString());

            return result;
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