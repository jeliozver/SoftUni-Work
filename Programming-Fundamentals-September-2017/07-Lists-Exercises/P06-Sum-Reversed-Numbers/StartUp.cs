namespace P06_Sum_Reversed_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] {' ',}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            long sum = 0;

            foreach (int num in numbers)
            {
                int reversed = ReverseInt(num);
                sum += reversed;
            }

            Console.WriteLine(sum);
        }

        private static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
}