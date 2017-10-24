namespace P01_Convert_From_Base_10_to_Base_N
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();

            var toBase = numbers[0];
            var baseTenNum = numbers[1];

            Console.WriteLine(ConvertToBaseN(baseTenNum, toBase));
        }

        private static string ConvertToBaseN(BigInteger baseTenNum, BigInteger toBase)
        {
            var builder = new StringBuilder();

            do
            {
                var result = baseTenNum % toBase;
                builder.Insert(0, result);
                baseTenNum /= toBase;

            } while (baseTenNum > 0);

            string resultStr = builder.ToString();

            return resultStr;
        }
    }
}