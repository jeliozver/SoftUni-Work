using System;

namespace PB_Aug_2016_3_Hotel_Room
{
    class hotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int days = int.Parse(Console.ReadLine());

            double apartmentPrice = 0.0;
            double studioPrice = 0.0;

            if (month == "may" || month == "october")
            {
                apartmentPrice = 65 * days;
                studioPrice = 50 * days;

                if (days > 14)
                {
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.10); 
                    studioPrice = studioPrice - (studioPrice * 0.30);
                }
                else if (days > 7 && days <= 14)
                {
                    studioPrice = studioPrice - (studioPrice * 0.05);
                }
            }
            else if (month == "june" || month == "september")
            {
                apartmentPrice = 68.70 * days;
                studioPrice = 75.20 * days;

                if (days > 14)
                {
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.10);
                    studioPrice = studioPrice - (studioPrice * 0.20);
                }
            }
            else if (month == "july" || month == "august")
            {
                apartmentPrice = 77 * days;
                studioPrice = 76 * days;

                if (days > 14)
                {
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.10);
                }
            }

            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
    }
}
