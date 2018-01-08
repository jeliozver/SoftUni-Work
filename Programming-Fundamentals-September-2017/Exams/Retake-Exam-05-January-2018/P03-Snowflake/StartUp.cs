namespace P03_Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            int coreLenght = 0;

            for (int i = 1; i <= 5; i++)
            {
                string currentElement = Console.ReadLine();

                if (!IsElementValid(currentElement, i))
                {
                    Console.WriteLine("Invalid");
                    return;
                }

                if (i == 3)
                {
                    coreLenght = GetCoreLenght(currentElement);
                }
            }

            Console.WriteLine("Valid");
            Console.WriteLine($"{coreLenght}");
        }

        public static int GetCoreLenght(string element)
        {
            string corePattern = @"^([^0-9A-Za-z]+)([0-9\\_]+)([A-Za-z]+)([0-9\\_]+)([^0-9A-Za-z]+)$";

            var match = Regex.Match(element, corePattern);

            string core = match.Groups[3].Value;

            return core.Length;
        }

        public static bool IsElementValid(string element, int index)
        {
            switch (index)
            {
                case 1:
                case 5:
                    string surfacePattern = @"^[^0-9A-Za-z]*$";
                    return Regex.IsMatch(element, surfacePattern);

                case 2:
                case 4:
                    string mantlePattern = @"^[0-9\\_]+$";
                    return Regex.IsMatch(element, mantlePattern);

                default:
                    string corePattern = @"^([^0-9A-Za-z]+)([0-9\\_]+)([A-Za-z]+)([0-9\\_]+)([^0-9A-Za-z]+)$";
                    return Regex.IsMatch(element, corePattern);
            }
        }
    }
}