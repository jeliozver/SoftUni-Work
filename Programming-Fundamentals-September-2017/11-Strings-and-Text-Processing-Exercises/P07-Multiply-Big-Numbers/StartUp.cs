namespace P07_Multiply_Big_Numbers
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            string numberOne = Console.ReadLine()
                .TrimStart('0');
            string numberTwo = Console.ReadLine()
                .TrimStart('0');

            if (numberTwo == string.Empty)
            {
                Console.WriteLine(0);
            }
            else if (numberTwo == "1")
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                string result = numberOne;

                for (int i = 1; i < int.Parse(numberTwo); i++)
                {
                    result = SumBigNumbers(result, numberOne);
                }

                Console.WriteLine(result);
            }
        }

        public static string SumBigNumbers(string numberOne, string numberTwo)
        {
            if (numberOne.Length > numberTwo.Length)
            {
                numberTwo = numberTwo.PadLeft(numberOne.Length, '0');
            }
            else
            {
                numberOne = numberOne.PadLeft(numberTwo.Length, '0');
            }

            var carry = 0;

            var result = new StringBuilder();

            for (int i = numberOne.Length - 1; i >= 0; i--)
            {
                var sum = int.Parse(numberOne[i].ToString())
                          + int.Parse(numberTwo[i].ToString()) + carry;

                carry = sum / 10;
                var remainder = sum % 10;
                result.Append(remainder);

                if (i == 0 && carry != 0)
                {
                    result.Append(carry);
                }
            }

            char[] resultArray = result
                .ToString()
                .ToCharArray();

            Array.Reverse(resultArray);

            return new string(resultArray);
        }
    }
}