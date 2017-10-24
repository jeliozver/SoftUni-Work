using System;

namespace Crossing_Sequences
{
    class CrossingSequences
    {
        static void Main(string[] args)
        {
            int t0 = int.Parse(Console.ReadLine());
            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());

            int spiralStart = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            if (spiralStart == t0 || spiralStart == t1 || spiralStart == t2)
            {
                Console.WriteLine(spiralStart);
                return;
            }

            int tribNext = t0 + t1 + t2;
            int spiralInc = 0;
            int spiralStepMul = 1;
            int spiralNext = spiralStart;


            while (tribNext <= 1000000 && spiralNext <= 1000000)
            {
                if (spiralNext == tribNext || spiralNext == t0 || spiralNext == t1 || spiralNext == t2)
                {
                    Console.WriteLine(spiralNext);
                    return;
                }
                else if (tribNext < spiralNext)
                {
                    tribNext = t0 + t1 + t2;
                    t0 = t1;
                    t1 = t2;
                    t2 = tribNext;
                }
                else
                {
                    spiralNext += spiralStepMul * step;
                    spiralInc++;

                    if (spiralInc == 2)
                    {
                        spiralStepMul++;
                        spiralInc = 0;
                    }
                }
            }

            Console.WriteLine("No");
        }
    }
}