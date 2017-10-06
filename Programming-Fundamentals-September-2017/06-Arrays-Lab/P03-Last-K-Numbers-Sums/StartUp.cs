namespace P03_Last_K_Numbers_Sums
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
   
            long[] sequence = new long[n];
            sequence[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (int j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += sequence[j];
                    }
                }

                sequence[i] = sum;
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}