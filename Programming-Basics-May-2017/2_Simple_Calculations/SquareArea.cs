using System;

namespace Square_Area
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            int area = a * a;

            Console.Write("Square = ");
            Console.WriteLine(area);
        }
    }
}
