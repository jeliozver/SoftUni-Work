namespace P10_Multiplication_Table_2
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int sum = 0;

            if (multiplier > 10)
            {
                sum = n * multiplier;
                Console.WriteLine($"{n} X {multiplier} = {sum}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    sum = n * i;
                    Console.WriteLine($"{n} X {i} = {sum}");
                }
            }
        }
    }
}
