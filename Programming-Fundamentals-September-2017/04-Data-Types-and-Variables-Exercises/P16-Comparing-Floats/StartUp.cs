namespace P16_Comparing_Floats
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            if (Math.Abs(numberOne - numberTwo) >= eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}