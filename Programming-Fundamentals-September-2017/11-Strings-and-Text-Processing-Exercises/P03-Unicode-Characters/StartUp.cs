namespace P03_Unicode_Characters
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();

            Console.WriteLine(ConvertToUnicode(inputString));
        }

        public static string ConvertToUnicode(string input)
        {
            var result = new StringBuilder();

            foreach (var letter in input)
            {
                result.Append("\\u");
                result.Append(((int)letter).ToString("x4"));
            }

            return result.ToString();
        }
    }
}