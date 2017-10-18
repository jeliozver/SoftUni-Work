namespace P05_Fibonacci_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciIterative(n));
        }

        public static int FibonacciIterative(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;

            int prevPrev = 1;
            int prev = 1;
            int result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = prev + prevPrev;
                prevPrev = prev;
                prev = result;
            }

            return result;
        }
    }
}   