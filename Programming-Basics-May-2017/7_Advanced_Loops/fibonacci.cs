using System;

namespace Fibonacci
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("1");
                return;
            }

            int fibNum1 = 1;
            int fibNum2 = 1;
            int fibNumNext = 0;

            for (int i = 0; i < n - 1; i++)
            {
                fibNumNext = fibNum1 + fibNum2;

                fibNum1 = fibNum2;
                fibNum2 = fibNumNext;
            }

            Console.WriteLine(fibNumNext);
        }
    }
}