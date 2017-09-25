using System;

namespace Math_Power
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            Console.WriteLine(CalcPow(num, pow));
        }

        static double CalcPow(double num, double pow)
        {
            double result = Math.Pow(num, pow);
            return result;
        }
    }
}
