using System;

namespace PB_March_2_2016_6_Magic_Combination
{
    class MagicCombination
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());

            for (int digit1 = 1; digit1 <= 9; digit1++)
            {
                for (int digit2 = 1; digit2 <= 9; digit2++)
                {
                    for (int digit3 = 1; digit3 <= 9; digit3++)
                    {
                        for (int digit4 = 1; digit4 <= 9; digit4++)
                        {
                            for (int digit5 = 1; digit5 <= 9; digit5++)
                            {
                                for (int digit6 = 1; digit6 <= 9; digit6++)
                                {
                                    if (digit1 * digit2 * digit3 * digit4 * digit5 * digit6 == magicNumber)
                                    {
                                        Console.Write($"{digit1}{digit2}{digit3}{digit4}{digit5}{digit6} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}