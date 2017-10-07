namespace P04_Sieve_of_Eratosthenes
{
    using System;
    using System.Linq;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] array = new bool[n + 1];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (array[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        array[j] = false;
                    }
                }
            }

            int[] primes = new int[n + 1];

            for (int i = 2; i < primes.Length; i++)
            {
                if (array[i])
                {
                    primes[i] = i;
                }
            }

            primes = primes.Except(new int[] { 0 }).ToArray();
            Console.WriteLine(string.Join(" ", primes));
        }
    }
}