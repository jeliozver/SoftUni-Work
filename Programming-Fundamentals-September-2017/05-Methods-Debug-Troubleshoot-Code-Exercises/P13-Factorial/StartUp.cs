namespace P13_Factorial
{
    using System;
    using System.Numerics;
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcFactorial(number));
        }

        public static BigInteger CalcFactorial(int number)
        {
            BigInteger factorial = 1;

            while (number > 1)
            {
                factorial *= number;
                number--;
            }

            return factorial;
        }
    }
}