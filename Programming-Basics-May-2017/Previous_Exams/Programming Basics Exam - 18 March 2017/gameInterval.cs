using System;

namespace PB_March_1_2017_4_Game_of_Interval
{
    class gameInterval
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double points = 0.0;
            double zeroToNineCount = 0.0;
            double tenCount = 0.0;
            double twentyCount = 0.0;
            double thirtyCount = 0.0;
            double fourtyCount = 0.0;
            double invalidCount = 0.0;

            for (int i = 0; i < moves; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if  (num < 0 || num > 50)
                {
                    points /= 2;
                    invalidCount++;
                    
                }
                else if (num >= 40 && num <= 50)
                {
                    points += 100;
                    fourtyCount++;
                }
                else if (num >= 30 && num <= 39)
                {
                    points += 50;
                    thirtyCount++;
                }
                else if (num >= 20 && num <= 29)
                {
                    points += num * 0.40;
                    twentyCount++;
 
                }
                else if (num >= 10 && num <= 19)
                {
                    points += num * 0.30;
                    tenCount++;

                }
                else if (num >= 0 && num <= 9)
                {
                    points += num * 0.20;
                    zeroToNineCount++;
                }
            }

            double zeroToNinePerc = (zeroToNineCount / moves) * 100;
            double tenPerc = (tenCount / moves) * 100;
            double twentyPerc = (twentyCount / moves) * 100;
            double thirtyPerc = (thirtyCount / moves) * 100;
            double fourtyPerc = (fourtyCount / moves) * 100;
            double invalidPerc = (invalidCount / moves) * 100;

            Console.WriteLine("{0:f2}", points);
            Console.WriteLine("From 0 to 9: {0:f2}%",zeroToNinePerc);
            Console.WriteLine("From 10 to 19: {0:f2}%", tenPerc);
            Console.WriteLine("From 20 to 29: {0:f2}%", twentyPerc);
            Console.WriteLine("From 30 to 39: {0:f2}%", thirtyPerc);
            Console.WriteLine("From 40 to 50: {0:f2}%", fourtyPerc);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalidPerc);
        }
    }
}
