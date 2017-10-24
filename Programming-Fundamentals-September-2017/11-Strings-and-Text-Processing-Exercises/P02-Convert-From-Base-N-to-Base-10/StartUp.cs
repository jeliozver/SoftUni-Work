namespace P02_Convert_From_Base_N_to_Base_10
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();

            var baseN = numbers[0];
            var number = numbers[1];

            Console.WriteLine(ConvertFromBaseN(baseN, number));
        }

        private static string ConvertFromBaseN(BigInteger baseN, BigInteger number)
        {
            BigInteger result = 0;
            int index = 0;

            while (number > 0)
            {
                var digit = number % 10;
                result += digit * BigInteger.Pow(baseN, index++);
                number /= 10;
            }

            string resultStr = result.ToString();

            return resultStr;
        }
    }
}