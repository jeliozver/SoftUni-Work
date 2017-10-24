namespace P01_Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"\b[A-Z][a-z]+[' '][A-Z][a-z]+\b";

            string namesList = Console.ReadLine();

            var matchedNames = Regex.Matches(namesList, pattern);

            foreach (var name in matchedNames)
            {
                Console.Write($"{name} ");
            }

            Console.WriteLine();
        }
    }
}