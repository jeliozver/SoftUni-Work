using System;

namespace PB_Sep_2017_3_Photo_Pictures
{
    class PhotoPictures
    {
        static void Main(string[] args)
        {
            int photosCount = int.Parse(Console.ReadLine());
            string photosSize = Console.ReadLine();
            string orderType = Console.ReadLine();

            double discountPerc = 0.00;
            double discount = 0.00;
            double photosPrice = 0.00;

            if (photosSize == "9X13")
            {
                photosPrice = photosCount * 0.16;

                if (photosCount >= 50)
                {
                    discountPerc = 0.05;
                }

                discount = photosPrice * discountPerc;
                photosPrice -= discount;

                if (orderType == "online")
                {
                    discount = photosPrice * 0.02;
                    photosPrice -= discount;
                }
            }
            else if (photosSize == "10X15")
            {
                photosPrice = photosCount * 0.16;

                if (photosCount >= 80)
                {
                    discountPerc = 0.03;
                }

                discount = photosPrice * discountPerc;
                photosPrice -= discount;

                if (orderType == "online")
                {
                    discount = photosPrice * 0.02;
                    photosPrice -= discount;
                }
            }
            else if (photosSize == "13X18")
            {
                photosPrice = photosCount * 0.38;

                if (photosCount >= 50 && photosCount <= 100)
                {
                    discountPerc = 0.03;
                }
                else if (photosCount > 100)
                {
                    discountPerc = 0.05;
                }

                discount = photosPrice * discountPerc;
                photosPrice -= discount;

                if (orderType == "online")
                {
                    discount = photosPrice * 0.02;
                    photosPrice -= discount;
                }
            }
            else if (photosSize == "20X30")
            {
                photosPrice = photosCount * 2.90;

                if (photosCount >= 10 && photosCount <= 50)
                {
                    discountPerc = 0.07;
                }
                else if (photosCount > 50)
                {
                    discountPerc = 0.09;
                }

                discount = photosPrice * discountPerc;
                photosPrice -= discount;

                if (orderType == "online")
                {
                    discount = photosPrice * 0.02;
                    photosPrice -= discount;
                }
            }

            Console.WriteLine($"{photosPrice:f2}BGN");
        }
    }
}