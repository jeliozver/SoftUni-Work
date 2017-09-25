using System;

namespace PB_June_2017_1_Charity_Campaign
{
    class CharityCampaign
    {
        static void Main(string[] args)
        {
            int campaignDays = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesPerWorker = cakes * 45;
            double wafflesPerWorker = waffles * 5.80;
            double pancakesPerWorker = pancakes * 3.20;

            double sumTotalPerDay = (cakesPerWorker + wafflesPerWorker + pancakesPerWorker) * workers;
            double sumTotalCampaign = sumTotalPerDay * campaignDays;
            double result = sumTotalCampaign - (sumTotalCampaign / 8);

            Console.WriteLine($"{result:f2}");
        }
    }
}
