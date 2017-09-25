using System;

namespace Sequence_2k_Plus_1
{
    class sequence2kPlusOne
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            while (num <= n)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
