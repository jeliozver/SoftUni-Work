namespace PB_Dec_2_2017_3_Ivanovis_Holiday
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transport = Console.ReadLine();

            decimal destinationPrice = 0m;
            decimal transportPrice = 0m;

            switch (destination)
            {
                case "Miami":
                    if (days > 15)
                    {
                        destinationPrice = days * (2 * 20.00m + 3 * 10.00m);
                        destinationPrice = destinationPrice + (destinationPrice * 0.25m);
                    }
                    else if (days >= 11 && days <= 15)
                    {
                        destinationPrice = days * ((2 * 22.99m) + (3 * 11.99m));
                        destinationPrice = destinationPrice + (destinationPrice * 0.25m);
                    }
                    else if (days >= 1 && days <= 10)
                    {
                        destinationPrice = days * ((2 * 24.99m) + (3 * 14.99m));
                        destinationPrice = destinationPrice + (destinationPrice * 0.25m);
                    }
                    break;
                case "Canary Islands":
                    if (days > 15)
                    {
                        destinationPrice = days * ((2 * 28.00m) + (3 * 22.00m));
                        destinationPrice = destinationPrice + (destinationPrice * 0.25m);
                    }
                    else if (days >= 11 && days <= 15)
                    {
                        destinationPrice = days * ((2 * 30.50m) + (3 * 25.60m));
                        destinationPrice = destinationPrice + (destinationPrice * 0.25m);
                    }
                    else if (days >= 1 && days <= 10)
                    {
                        destinationPrice = days * ((2 * 32.50m) + (3 * 28.50m));
                        destinationPrice = destinationPrice + (destinationPrice * 0.25m);
                    }
                    break;
                case "Philippines":
                    if (days > 15)
                    {
                        destinationPrice = days * ((2 * 38.50m) + (3 * 32.40m));
                        destinationPrice = destinationPrice + (destinationPrice * 0.25m);
                    }
                    else if (days >= 11 && days <= 15)
                    {
                        destinationPrice = days * ((2 * 41.00m) + (3 * 36.00m));
                        destinationPrice = destinationPrice + (destinationPrice * 0.25m);
                    }
                    else if (days >= 1 && days <= 10)
                    {
                        destinationPrice = days * ((2 * 42.99m) + (3 * 39.99m));
                        destinationPrice = destinationPrice + (destinationPrice * 0.25m);
                    }
                    break;
            }

            switch (transport)
            {
                case "train":
                    transportPrice = 2 * 22.30m + 3 * 12.50m;
                    break;
                case "bus":
                    transportPrice = 2 * 45.00m + 3 * 37.00m;
                    break;
                case "airplane":
                    transportPrice = 2 * 90.00m + 3 * 68.50m;
                    break;
            }

            decimal totalPrice = destinationPrice + transportPrice;
            Console.WriteLine($"{totalPrice:f3}");
        }
    }
}