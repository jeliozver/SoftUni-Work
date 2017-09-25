using System;

namespace Five_Special_Letters
{
    class FiveSpecialLetters
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            bool isPrinted = false;

            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        for (int d = 0; d < 5; d++)
                        {
                            for (int e = 0; e < 5; e++)
                            {
                                string pattern = "abcde";
                                string current = "" +
                                    pattern[a] +
                                    pattern[b] +
                                    pattern[c] +
                                    pattern[d] +
                                    pattern[e];

                                string unique = string.Empty;

                                for (int l = 0; l < current.Length; l++)
                                {
                                    if (unique.IndexOf(current[l]) == -1)
                                    {
                                        unique += current[l];
                                    }
                                }

                                int sum = 0;

                                for (int l = 0; l < unique.Length; l++)
                                {
                                    int add = 0;
                                   
                                    switch (unique[l])
                                    {
                                        case 'a': add = 5; break;
                                        case 'b': add = -12; break;
                                        case 'c': add = 47; break;
                                        case 'd': add = 7; break;
                                        case 'e': add = -32; break;
                                    }

                                    sum += (l + 1) * add;
                                }

                                if (sum >= start && sum <= end)
                                {
                                    isPrinted = true;
                                    Console.Write($"{current} ");
                                }
                            }
                        }
                    }
                }
            }
           
            if (!isPrinted)
            {
                Console.WriteLine("No");
            }
        }
    }
}