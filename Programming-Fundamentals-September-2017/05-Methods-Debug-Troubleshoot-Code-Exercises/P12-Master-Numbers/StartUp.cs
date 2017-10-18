namespace P12_Master_Numbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && IsSumOfDigitsDivisibleBySeven(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            int n = num;
            int rev = 0;
            while (num > 0)
            {
                int dig = num % 10;
                rev = rev * 10 + dig;
                num = num / 10;
            }

            if (n == rev)
            {
                return true;
            }

            return false;
        }

        public static bool IsSumOfDigitsDivisibleBySeven(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }

        public static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                int digitToCheck = num % 10;

                if (digitToCheck % 2 == 0)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }
    }
}