using System;

namespace PB_April_2016_2_Sleepy_Tom_Cat
{
    class sleepyTomCat
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());

            double workDays = 365 - restDays;
            double realPlayTime = (workDays * 63) + (restDays * 127);

            if (realPlayTime <= 30000)
            {
                double minutesDifference = 30000 - realPlayTime;
                double hours = 0;

                while (minutesDifference >= 60)
                {
                    minutesDifference -= 60;
                    hours += 1;
                }

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutesDifference);
            }
            else
            {
                double minutesDifference = realPlayTime - 30000;
                double hours = 0;

                while (minutesDifference >= 60)
                {
                    minutesDifference -= 60;
                    hours += 1;
                }

                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutesDifference);
            }
        }
    }
}