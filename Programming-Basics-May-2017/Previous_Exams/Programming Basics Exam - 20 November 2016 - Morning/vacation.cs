using System;

namespace PB_NovM_2016_3_Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            string transportType = Console.ReadLine().ToLower();

            double hotelPrice = days * 82.99;
            double transportPrice = 0.00;
            double comission = 0.00;
            double totalPrice = 0.00;

            if (transportType == "train")
            {
                transportPrice = ((adults * 24.99) + (students * 14.99)) * 2;
                if (adults + students >= 50)
                {
                    transportPrice /= 2;
                }
                comission = (transportPrice + hotelPrice) * 0.10;
                totalPrice = transportPrice + hotelPrice + comission;
            }
            else if (transportType == "bus")
            {
                transportPrice = ((adults * 32.50) + (students * 28.50)) * 2;
                comission = (transportPrice + hotelPrice) * 0.10;
                totalPrice = transportPrice + hotelPrice + comission;
            }
            else if (transportType == "boat")
            {
                transportPrice = ((adults * 42.99) + (students * 39.99)) * 2;
                comission = (transportPrice + hotelPrice) * 0.10;
                totalPrice = transportPrice + hotelPrice + comission;
            }
            else if (transportType == "airplane")
            {
                transportPrice = ((adults * 70.00) + (students * 50.00)) * 2;
                comission = (transportPrice + hotelPrice) * 0.10;
                totalPrice = transportPrice + hotelPrice + comission;
            }

            Console.WriteLine("{0:f2}", totalPrice);
        }
    }
}