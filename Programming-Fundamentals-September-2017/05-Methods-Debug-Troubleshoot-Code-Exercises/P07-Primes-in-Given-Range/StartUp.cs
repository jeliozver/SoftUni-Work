namespace P07_Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            Console.WriteLine(String.Join(", ", FindPrimesInRange(startNum, endNum)));
        }

        public static bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primesInRange = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primesInRange.Add(i);
                }
            }

            return primesInRange;
        }

    }
}