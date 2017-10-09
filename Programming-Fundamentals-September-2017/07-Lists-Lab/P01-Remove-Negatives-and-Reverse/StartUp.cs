namespace P01_Remove_Negatives_and_Reverse
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = numbers.Count; i > 0; i--)
            {
                if (numbers[i - 1] >= 0)
                {
                    result.Add(numbers[i - 1]);
                }
            }

            Console.WriteLine(result.Count != 0 ? string.Join(" ", result) : "empty");
        }
    }
}