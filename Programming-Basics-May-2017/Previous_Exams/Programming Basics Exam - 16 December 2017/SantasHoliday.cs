namespace PB_Dec_2017_3_Santas_Holiday
{
    using System;

    public class SantasHoliday
    {
        public static void Main()
        {
            int daysStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();

            decimal totalPrice = 0m;
            int daystoPay = daysStay - 1;

            switch (roomType)
            {
                case "room for one person":
                    totalPrice = 18.00m * daystoPay;
                    break;

                case "apartment":
                    totalPrice = 25.00m * daystoPay;

                    if (daysStay > 15)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.50m);
                    }
                    else if (daysStay >= 10 && daysStay <= 15)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.35m);
                    }
                    else if (daysStay < 10)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.30m);
                    }
                    break;

                case "president apartment":
                    totalPrice = 35.00m * daystoPay;

                    if (daysStay > 15)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.20m);
                    }
                    else if (daysStay >= 10 && daysStay <= 15)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.15m);
                    }
                    else if (daysStay < 10)
                    {
                        totalPrice = totalPrice - (totalPrice * 0.10m);
                    }
                    break;
            }

            switch (evaluation)
            {
                case "positive":
                    totalPrice = totalPrice + (totalPrice * 0.25m);
                    break;

                case "negative":
                    totalPrice = totalPrice - (totalPrice * 0.10m);
                    break;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}