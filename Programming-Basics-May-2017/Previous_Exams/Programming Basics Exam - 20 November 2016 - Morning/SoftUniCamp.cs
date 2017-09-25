using System;

namespace PB_NovM_2016_4_SoftUni_Camp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double car = 0;
            double van = 0;
            double smallBuss = 0;
            double bigBuss = 0;
            double train = 0;
            double peopleTotal = 0;

            for (int i = 0; i < groups; i++)
            {
                int groupNum = int.Parse(Console.ReadLine());

                peopleTotal += groupNum;

                if (groupNum >= 41)
                {
                    train += groupNum;
                }
                else if (groupNum >= 26 && groupNum <= 40)
                {
                    bigBuss += groupNum;
                }
                else if (groupNum >= 13 && groupNum <= 25)
                {
                    smallBuss += groupNum;
                }
                else if (groupNum >= 6 && groupNum <= 12)
                {
                    van += groupNum;
                }
                else if (groupNum <= 5)
                {
                    car += groupNum;
                }
            }

            double carPerc = car / peopleTotal * 100;
            double vanPerc = van / peopleTotal * 100;
            double smallBussPerc = smallBuss / peopleTotal * 100;
            double bigBussPerc = bigBuss / peopleTotal * 100;
            double trainPerc = train / peopleTotal * 100;

            Console.WriteLine($"{carPerc:f2}%");
            Console.WriteLine($"{vanPerc:f2}%");
            Console.WriteLine($"{smallBussPerc:f2}%");
            Console.WriteLine($"{bigBussPerc:f2}%");
            Console.WriteLine($"{trainPerc:f2}%");
        }
    }
}
