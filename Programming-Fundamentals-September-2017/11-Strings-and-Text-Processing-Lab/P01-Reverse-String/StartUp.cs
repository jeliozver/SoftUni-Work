namespace P01_Reverse_String
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string stringToReverse = Console.ReadLine();
            Console.WriteLine(ReverseString(stringToReverse));
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