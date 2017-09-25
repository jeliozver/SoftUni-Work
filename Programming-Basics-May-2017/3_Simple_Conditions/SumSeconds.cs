using System;

namespace Sum_Seconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            double sec = time1 + time2 + time3;
            double min = 0;

            while (sec >= 60)
            {
                sec -= 60;
                min++;
            }

            if (sec < 10)
            {
                Console.WriteLine("{0}:0{1}", min, sec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", min, sec);
            }
        }
    }
}
