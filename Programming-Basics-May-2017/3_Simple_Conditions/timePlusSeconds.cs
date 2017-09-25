using System;

namespace Time_Plus_15_Seconds
{
    class timePlusSeconds
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            int minsAdded = mins + 15;

            if (minsAdded > 59)
            {
                hours = hours + 1;
                minsAdded = minsAdded - 60;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            if (minsAdded < 10)
            {
                Console.WriteLine("{0}:0{1}", hours, minsAdded);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minsAdded);
            }
        }
    }
}
