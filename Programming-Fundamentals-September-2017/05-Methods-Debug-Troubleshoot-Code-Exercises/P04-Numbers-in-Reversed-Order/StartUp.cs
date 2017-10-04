namespace P04_Numbers_in_Reversed_Order
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));
        }

        private static string ReverseString(string stringToReverse)
        {
            string stringReversed = string.Empty;

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                stringReversed += stringToReverse[i];
            }

            return stringReversed;
        }
    }
}