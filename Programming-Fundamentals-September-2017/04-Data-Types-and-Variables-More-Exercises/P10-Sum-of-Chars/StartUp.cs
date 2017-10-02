namespace P10_Sum_of_Chars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            byte interval = byte.Parse(Console.ReadLine());

            int sum = 0;

            for (byte i = 1; i <= interval; i++)
            {
                char currentLetter = char.Parse(Console.ReadLine());
                sum += currentLetter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}