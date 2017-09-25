using System;

namespace Vowels_Sum
{
    class vowelsSum
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vowelsSum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (letter == 'a')
                {
                    vowelsSum += 1;
                }
                else if (letter == 'e')
                {
                    vowelsSum += 2;
                }
                else if (letter == 'i')
                {
                    vowelsSum += 3;
                }
                else if (letter == 'o')
                {
                    vowelsSum += 4;
                }
                else if (letter == 'u')
                {
                    vowelsSum += 5;
                }
            }

            Console.WriteLine(vowelsSum);
        }
    }
}
