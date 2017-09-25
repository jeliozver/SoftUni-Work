using System;

namespace PB_March_1_2016_2_Transport_Price
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double priceTotal = 0;


            if (distance >= 100)
            {
                priceTotal = distance * 0.06;
            }
            else if (distance >= 20)
            {
                priceTotal = distance * 0.09;
            }
            else
            {
                if (dayOrNight == "day")
                {
                    priceTotal = 0.70 + (distance * 0.79);
                }
                else
                {
                    priceTotal = 0.70 + (distance * 0.90);
                }
            }

            Console.WriteLine("{0:F2}", priceTotal);
        }
    }
}
