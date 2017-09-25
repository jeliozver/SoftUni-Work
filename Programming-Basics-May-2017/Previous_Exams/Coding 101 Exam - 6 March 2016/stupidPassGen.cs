using System;

namespace PB_March_2016_6_Stupid_Pass_Gen
{
    class stupidPassGen
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int n1 = 1; n1 <= n; n1++)
            {
                for (int n2 = 1; n2 <= n; n2++)
                {
                    for (char l1 = 'a'; l1 < 'a' + l; l1++)
                    {
                        for (char l2 = 'a'; l2 < 'a' + l; l2++)
                        {
                            for (int n3 = Math.Max(n1, n2) + 1; n3 <= n; n3++)
                            {
                                Console.Write($"{n1}{n2}{l1}{l2}{n3} ");
                            }
                        }
                    }
                }
            }
        }
    }
}