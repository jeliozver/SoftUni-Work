using System;

namespace PB_NovE_2016_4_Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int loads = int.Parse(Console.ReadLine());

            double vanLoads = 0.0;
            double truckLoads = 0.0;
            double trainLoads = 0.0;
            double loadsSum = 0.0;

            for (int i = 0; i < loads; i++)
            {
                double tonsLoad = double.Parse(Console.ReadLine());

                loadsSum += tonsLoad;

                if (tonsLoad >= 12)
                {
                    trainLoads += tonsLoad;
                }
                else if (tonsLoad >= 4 && tonsLoad <= 11)
                {
                    truckLoads += tonsLoad;
                }
                else if (tonsLoad <= 3)
                {
                    vanLoads += tonsLoad;
                }
            }

            double vanPerc = vanLoads / loadsSum * 100;
            double truckPerc = truckLoads / loadsSum * 100;
            double trainPerc = trainLoads / loadsSum * 100;
            double avgPerTone = ((vanLoads * 200) + (truckLoads * 175) + (trainLoads * 120)) / loadsSum;

            Console.WriteLine("{0:f2}", avgPerTone);
            Console.WriteLine("{0:f2}%", vanPerc);
            Console.WriteLine("{0:f2}%", truckPerc);
            Console.WriteLine("{0:f2}%", trainPerc);
        }
    }
}