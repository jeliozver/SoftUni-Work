namespace P07_Math_Power
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateMathPower(number, power));
        }

        private static double CalculateMathPower(double num, double pow)
        {
            double result = Math.Pow(num, pow);
            return result;
        }
    }
}