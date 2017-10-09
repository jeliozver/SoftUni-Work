namespace P03_Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            bool hasSummed = true;

            while (hasSummed)
            {
                hasSummed = false;
                int index = 0;
                decimal sum = 0;

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                    {
                        index = i - 1;
                        sum = numbers[i] + numbers[i - 1];
                        hasSummed = true;
                        break;
                    }
                }

                if (hasSummed)
                {
                    numbers.RemoveRange(index, 2);
                    numbers.Insert(index, sum);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}