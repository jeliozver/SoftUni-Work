namespace P09_Multiply_Evens_by_Odds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int numberAbsolute = Math.Abs(number);
            Console.WriteLine(GetMultipleOfEvensAndOdds(numberAbsolute));
        }

        public static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int summOdds = GetSumOfOddDigits(n);
            return sumEvens * summOdds;
        }

        public static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }

            return sum;
        }

        public static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                n /= 10;
            }

            return sum;
        }
    }
}