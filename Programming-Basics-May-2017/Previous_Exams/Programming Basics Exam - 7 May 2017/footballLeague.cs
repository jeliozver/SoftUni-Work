using System;

namespace PB_May_2017_4_Football_League
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            double stadiumCap = double.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());

            double sectorAFans = 0.0;
            double sectorBFans = 0.0;
            double sectorCFans = 0.0;
            double sectorDFans = 0.0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine().ToLower();
                if (sector == "a")
                {
                    sectorAFans++;
                }
                else if (sector == "b")
                {
                    sectorBFans++;
                }
                else if (sector == "v")
                {
                    sectorCFans++;
                }
                else if (sector == "g")
                {
                    sectorDFans++;
                }
            }

            double sectorAPerc = sectorAFans / fans * 100;
            double sectorBPerc = sectorBFans / fans * 100;
            double sectorCPerc = sectorCFans / fans * 100;
            double sectorDPerc = sectorDFans / fans * 100;
            double allPerc = fans / stadiumCap * 100;

            Console.WriteLine("{0:f2}%", sectorAPerc);
            Console.WriteLine("{0:f2}%", sectorBPerc);
            Console.WriteLine("{0:f2}%", sectorCPerc);
            Console.WriteLine("{0:f2}%", sectorDPerc);
            Console.WriteLine("{0:f2}%", allPerc);
        }
    }
}