namespace P14_Factorial_Trailing_Zeroes
{
    using System;
    using System.Numerics;
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(CalcTrailingZeroes(number));
        }

        private static BigInteger CalcFactorial(int number)
        {
            BigInteger factorial = 1;

            while (number > 1)
            {
                factorial *= number;
                number--;
            }

            return factorial;
        }

        private static BigInteger CalcTrailingZeroes(int number)
        {
            int trailingZerosCount = 0;
            BigInteger numToCheck = CalcFactorial(number);

            while (numToCheck > 0)
            {
                BigInteger digitToCheck = numToCheck % 10;

                if (digitToCheck == 0)
                {
                    trailingZerosCount++;
                }
                else
                {
                    break;
                }

                numToCheck /= 10;
            }

            return trailingZerosCount;
        }
    }
}