using System;

namespace PB_NovE_2016_3_Bike_Race
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string route = Console.ReadLine().ToLower();

            double juniorsFee = 0.00;
            double seniorsFee = 0.00;
            double totalFee = 0.00;
            double moneyLeft = 0.00;

            if (route == "trail")
            {
                juniorsFee = juniors * 5.50;
                seniorsFee = seniors * 7;
                totalFee = juniorsFee + seniorsFee;
                moneyLeft = totalFee - (totalFee * 0.05);
            }
            else if (route == "cross-country")
            {
                juniorsFee = juniors * 8;
                seniorsFee = seniors * 9.50;
                totalFee = juniorsFee + seniorsFee;
                if (juniors + seniors >= 50)
                {
                    totalFee = totalFee - (totalFee * 0.25);
                }
                moneyLeft = totalFee - (totalFee * 0.05);
            }
            else if (route == "downhill")
            {
                juniorsFee = juniors * 12.25;
                seniorsFee = seniors * 13.75;
                totalFee = juniorsFee + seniorsFee;
                moneyLeft = totalFee - (totalFee * 0.05);
            }
            else if (route == "road")
            {
                juniorsFee = juniors * 20;
                seniorsFee = seniors * 21.50;
                totalFee = juniorsFee + seniorsFee;
                moneyLeft = totalFee - (totalFee * 0.05);
            }

            Console.WriteLine("{0:f2}", moneyLeft);
        }
    }
}