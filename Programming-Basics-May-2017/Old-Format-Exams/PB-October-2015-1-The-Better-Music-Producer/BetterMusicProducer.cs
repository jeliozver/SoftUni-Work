using System;

namespace PB_October_2015_1_The_Better_Music_Producer
{
    class BetterMusicProducer
    {
        static void Main(string[] args)
        {
            decimal albumsEU = decimal.Parse(Console.ReadLine());
            decimal priceEuro = decimal.Parse(Console.ReadLine());
            decimal albumsNA = decimal.Parse(Console.ReadLine());
            decimal priceUsd = decimal.Parse(Console.ReadLine());
            decimal albumsSA = decimal.Parse(Console.ReadLine());
            decimal pricePesso = decimal.Parse(Console.ReadLine());

            decimal concerts = decimal.Parse(Console.ReadLine());
            decimal profitOneConcert = decimal.Parse(Console.ReadLine());

            decimal profitEU = (albumsEU * priceEuro) * 1.94m;
            decimal profitNA = (albumsNA * priceUsd) * 1.72m;
            decimal profitSA = (albumsSA * pricePesso) / 332.74m;

            decimal profitAlbums = profitEU + profitNA + profitSA;
            profitAlbums -= profitAlbums * 0.35m;
            profitAlbums -= profitAlbums * 0.20m;

            decimal profitConcerts = (concerts * profitOneConcert) * 1.94m;
            if (profitConcerts > 100000)
            {
                profitConcerts -= profitConcerts * 0.15m;
            }

            if (profitAlbums > profitConcerts)
            {
                Console.WriteLine($"Let's record some songs! They'll bring us {profitAlbums:f2}lv.");
            }
            else
            {
                Console.WriteLine($"On the road again! We'll see the world and earn {profitConcerts:f2}lv.");
            }
        }
    }
}