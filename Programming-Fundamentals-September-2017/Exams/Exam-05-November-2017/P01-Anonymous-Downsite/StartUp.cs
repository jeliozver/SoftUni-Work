namespace P01_Anonymous_Downsite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int numberWebsites = int.Parse(Console.ReadLine());
            int secKey = int.Parse(Console.ReadLine());

            decimal totalSum = 0m;
            var webSites = new List<string>();

            BigInteger token = BigInteger.Pow(secKey, numberWebsites);

            for (int i = 0; i < numberWebsites; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                string siteName = data[0];
                decimal visits = decimal.Parse(data[1]);
                decimal comVisits = decimal.Parse(data[2]);

                webSites.Add(siteName);

                totalSum += visits * comVisits;
            }

            foreach (var site in webSites)
            {
                Console.WriteLine(site);
            }

            Console.WriteLine($"Total Loss: {totalSum:f20}");
            Console.WriteLine($"Security Token: {token}");
        }
    }
}