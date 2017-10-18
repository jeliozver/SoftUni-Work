namespace P06_Byte_Flip
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(' ')
                .ToList();

            List<string> resize = input.Where(element => element.Length == 2).ToList();

            List<string> reverse = resize.Select(ReverseElements).ToList();

            reverse.Reverse();

            string result = string.Empty;

            foreach (var item in reverse)
            {
                result += (char)Convert.ToInt32(item, 16);
            }

            Console.WriteLine(result);
        }

        public static string ReverseElements(string stringToReverse)
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