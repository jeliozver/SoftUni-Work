using System;

namespace Count_the_Integers
{
    class CountIntegers
    {
        static void Main(string[] args)
        {
            int numbersCount = 0;

            try
            {
                while (numbersCount < 100)
                {
                    int n = int.Parse(Console.ReadLine());
                    numbersCount++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(numbersCount);
            }
        }
    }
}