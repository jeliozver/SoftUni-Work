using System;

namespace min_Number
{
    class minNum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                min = Math.Min(min, num);
            }

            Console.WriteLine("Max num: {0}", min);
        }
    }
}
