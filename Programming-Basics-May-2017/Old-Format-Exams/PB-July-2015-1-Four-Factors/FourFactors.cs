using System;

namespace PB_July_2015_1_Four_Factors
{
    class FourFactors
    {
        static void Main(string[] args)
        {
            long FG = long.Parse(Console.ReadLine());
            long FGA = long.Parse(Console.ReadLine());
            long TP = long.Parse(Console.ReadLine());
            long TOV = long.Parse(Console.ReadLine());
            long ORB = long.Parse(Console.ReadLine());
            long OppDRB = long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            long FTA = long.Parse(Console.ReadLine());

            decimal eFGPercentage = (FG + 0.5m * TP) / FGA;
            decimal TOVPerc = TOV / (FGA + 0.44m * FTA + TOV);
            decimal ORBPerc = (decimal)ORB / (ORB + OppDRB);
            decimal FTPerc = (decimal)FT / FGA;

            Console.WriteLine($"eFG% {eFGPercentage:f3}");
            Console.WriteLine($"TOV% {TOVPerc:f3}");
            Console.WriteLine($"ORB% {ORBPerc:f3}");
            Console.WriteLine($"FT% {FTPerc:f3}");
        }
    }
}