using System;

namespace PB_Dec_2016_6_Letters_Combinations
{
    class lettersCombinations
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char skip = char.Parse(Console.ReadLine());

            int combinationsSum = 0;

            for (char n1 = start; n1 <= end; n1++)
            {
                for (char n2 = start; n2 <= end; n2++)
                {
                    for (char n3 = start; n3 <= end; n3++)
                    {
                        if (n1 != skip && n2 != skip && n3 != skip)
                        {
                            Console.Write($"{n1}{n2}{n3} ");
                            combinationsSum++;
                        }
                    }
                }
            }
            Console.Write(combinationsSum);
        }
    }
}
