namespace P09_Multiplication_Table
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int sum = n * i;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
