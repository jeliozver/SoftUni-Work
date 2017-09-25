using System;

namespace Max_Number
{
    class maxNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {               
                int num = int.Parse(Console.ReadLine());
                max = Math.Max(max, num);
            }

            Console.WriteLine("Max num: {0}", max);
        }
    }
}
