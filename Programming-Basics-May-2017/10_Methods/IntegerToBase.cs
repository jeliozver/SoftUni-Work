using System;

namespace Integer_to_Base
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntToBase(num, toBase));
        }

        static string IntToBase(int number, int toBase)
        {
            int result = 0;
            string resultStr = string.Empty;
            do
            {
                result = number % toBase;
                resultStr = result + resultStr;
                number /= toBase;

            } while (number > 0);

            return resultStr;
        }
    }
}