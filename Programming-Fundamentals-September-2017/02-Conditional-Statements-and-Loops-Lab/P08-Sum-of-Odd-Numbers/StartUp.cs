namespace P08_Sum_of_Odd_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + i - 1);
                sum += i + i - 1;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
