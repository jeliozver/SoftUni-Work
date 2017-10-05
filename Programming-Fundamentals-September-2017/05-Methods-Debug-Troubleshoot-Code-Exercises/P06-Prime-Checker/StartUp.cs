namespace P06_Prime_Checker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        private static bool IsPrime(long n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}