using System;

namespace PB_March_2_2016_2_Pool_Pipes
{
    class poolPipes
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int pipe1Debit = int.Parse(Console.ReadLine());
            int pipe2Debit = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double pipe1Fill = pipe1Debit * time;
            double pipe2Fill = pipe2Debit * time;

            double pipe1FillPct = Math.Truncate(pipe1Fill / (pipe1Fill + pipe2Fill) * 100);
            double pipe2FillPct = Math.Truncate(pipe2Fill / (pipe1Fill + pipe2Fill) * 100);
            double poolFillPct = Math.Truncate((pipe1Fill + pipe2Fill) / poolVolume * 100);

            double overflow = (pipe1Fill + pipe2Fill) - poolVolume;

            if (pipe1Fill + pipe2Fill <= poolVolume)
            {
                Console.WriteLine("The pool is {0:F0}% full. Pipe 1: {1:F0}%. Pipe 2: {2:F0}%.",
                    poolFillPct, pipe1FillPct, pipe2FillPct);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:F1} liters.",
                    time, overflow);
            }
        }
    }
}