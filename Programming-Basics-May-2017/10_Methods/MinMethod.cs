using System;

namespace Min_Method
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMin());
            
        }

        static int GetMin()
        {
            int minNum = int.MaxValue;

            for (int i = 1; i <= 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                minNum = Math.Min(num, minNum);
            }

            return minNum;
        }
    }
}