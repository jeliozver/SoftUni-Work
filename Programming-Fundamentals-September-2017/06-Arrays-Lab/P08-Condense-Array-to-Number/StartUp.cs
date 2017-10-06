namespace P08_Condense_Array_to_Number
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            long[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            while (numbers.Length > 1)
            {
                long[] condensed = new long[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensed;
            }

            Console.WriteLine($"{numbers[0]}");
        }
    }
}