using System;

namespace House
{
    class house
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int starsCount = 1;
            if (n % 2 == 0)
            {
                starsCount++;
            }

            for (int roof = 0; roof < (n + 1) / 2; roof++)
            {
                int hyphensCount = (n - starsCount) / 2;
                string hyphens = new string('-', hyphensCount);
                string stars = new string('*', starsCount);
                Console.WriteLine($"{hyphens}{stars}{hyphens}");
                starsCount += 2;
            }

            starsCount = n - 2;

            for (int body = 0; body < n / 2; body++)
            {
                string stars = new string('*', starsCount);
                Console.WriteLine($"|{stars}|");
            }
        }
    }
}