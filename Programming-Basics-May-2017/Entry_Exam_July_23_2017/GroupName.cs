using System;

namespace _06_Group_Name
{
    class GroupName
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());
            char four = char.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());

            int combinations = 0;

            for (char i = 'A'; i <= one; i++)
            {
                for (char j = 'a'; j <= two; j++)
                {
                    for (char k = 'a'; k <= three; k++)
                    {
                        for (char l = 'a'; l <= four; l++)
                        {
                            for (int m = 0; m <= five; m++)
                            {
                                if (i == one && j == two && k == three && l == four && m == five)
                                {
                                    Console.WriteLine(combinations);
                                    return;
                                }

                                combinations++;
                            }
                        }
                    }
                }
            }
        }
    }
}