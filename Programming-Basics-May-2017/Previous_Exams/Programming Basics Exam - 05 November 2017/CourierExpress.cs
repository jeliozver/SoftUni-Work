namespace PB_November_2017_3_Courier_Express
{
    using System;

    public class CourierExpress
    {
        public static void Main()
        {
            decimal deliveryWeight = decimal.Parse(Console.ReadLine());
            string deliveryType = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());

            decimal pricePerKilometer = 0m;

            if (deliveryWeight >= 91 && deliveryWeight <= 150)
            {
                pricePerKilometer = 0.20m;
            }
            else if (deliveryWeight >= 41 && deliveryWeight <= 90)
            {
                pricePerKilometer = 0.15m;
            }
            else if (deliveryWeight >= 11 && deliveryWeight <= 40)
            {
                pricePerKilometer = 0.10m;
            }
            else if (deliveryWeight >= 1 && deliveryWeight <= 10)
            {
                pricePerKilometer = 0.05m;
            }
            else if (deliveryWeight < 1)
            {
                pricePerKilometer = 0.03m;
            }

            decimal deliveryPrice = distance * pricePerKilometer;

            if (deliveryType == "express")
            {
                decimal extraCostPerc = 0m;

                if (deliveryWeight >= 91 && deliveryWeight <= 150)
                {
                    extraCostPerc = 0.01m;
                }
                else if (deliveryWeight >= 41 && deliveryWeight <= 90)
                {
                    extraCostPerc = 0.02m;
                }
                else if (deliveryWeight >= 11 && deliveryWeight <= 40)
                {
                    extraCostPerc = 0.05m;
                }
                else if (deliveryWeight >= 1 && deliveryWeight <= 10)
                {
                    extraCostPerc = 0.40m;
                }
                else if (deliveryWeight < 1)
                {
                    extraCostPerc = 0.80m;
                }

                decimal extraCost = extraCostPerc * pricePerKilometer;
                extraCost *= deliveryWeight;
                extraCost *= distance;
                deliveryPrice =  extraCost + deliveryPrice;
            }

            Console.WriteLine("The delivery of your shipment with weight of " +
                              $"{deliveryWeight:f3} kg. would cost {deliveryPrice:f2} lv.");
        }
    }
}