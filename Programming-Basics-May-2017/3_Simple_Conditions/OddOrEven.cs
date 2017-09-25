using System;

namespace Odd_or_Even
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            double check = double.Parse(Console.ReadLine());

            if (check % 2 == 0)
            {
                Console.WriteLine("even", check);
            }
            else
            {
                Console.WriteLine("odd", check);
            }
        }
    }
}
