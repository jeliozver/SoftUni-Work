using System;

namespace PB_February_2016_2_Encoded_Answers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char answer = '0';
            int answerA = 0;
            int answerB = 0;
            int answerC = 0;
            int answerD = 0;

            string result = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                uint num = uint.Parse(Console.ReadLine());

                if (num % 4 == 0)
                {
                    answer = 'a';
                    answerA++;
                }
                else if (num % 4 == 1)
                {
                    answer = 'b';
                    answerB++;
                }
                else if (num % 4 == 2)
                {
                    answer = 'c';
                    answerC++;
                }
                else if (num % 4 == 3)
                {
                    answer = 'd';
                    answerD++;
                }

                result += $"{answer} ";
            }

            Console.WriteLine(result);
            Console.WriteLine($"Answer A: {answerA}");
            Console.WriteLine($"Answer B: {answerB}");
            Console.WriteLine($"Answer C: {answerC}");
            Console.WriteLine($"Answer D: {answerD}");
        }
    }
}