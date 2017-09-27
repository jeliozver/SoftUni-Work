namespace P06_Interval_of_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = Math.Min(firstNumber, secondNumber);
                    i <= Math.Max(firstNumber, secondNumber); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}