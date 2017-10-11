namespace P03_Min_Max_Sum_Average
{
    using System;
    using System.Linq;
    
    public class StartUp
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] numbers = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                numbers[i] = number;
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}