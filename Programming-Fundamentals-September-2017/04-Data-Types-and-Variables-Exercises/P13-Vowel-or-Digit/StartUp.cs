namespace P13_Vowel_or_Digit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string symbol = Console.ReadLine().ToLower();

            if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u" || symbol == "y")
            {
                Console.WriteLine("vowel");
            }
            else if (char.Parse(symbol) >= 48 && char.Parse(symbol) <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}