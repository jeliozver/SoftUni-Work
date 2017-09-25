using System;

namespace PB_MarchE_2_2017_4_Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricityPrice = 0.00;
            double waterPrice = 0.00;
            double internetPrice = 0.00;
            double othersPrice = 0.00;
            double totalPrice = 0.00;
            double average = 0.00;

            for (int i = 0; i < months; i++)
            {
                double electricityMonthly = double.Parse(Console.ReadLine());
                electricityPrice += electricityMonthly;
                waterPrice += 20.00;
                internetPrice += 15.00;
                othersPrice = (electricityPrice + waterPrice + internetPrice) + ((electricityPrice + waterPrice + internetPrice) * 0.20);
                totalPrice = electricityPrice + waterPrice + internetPrice + othersPrice;
            }

            average = totalPrice / months;

            Console.WriteLine("Electricity: {0:f2} lv", electricityPrice);
            Console.WriteLine("Water: {0:f2} lv", waterPrice);
            Console.WriteLine("Internet: {0:f2} lv", internetPrice);
            Console.WriteLine("Other: {0:f2} lv", othersPrice);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}