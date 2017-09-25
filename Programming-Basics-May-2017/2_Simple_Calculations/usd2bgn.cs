using System;


namespace USD_to_BGN
{
    class usd2bgn
    {
        static void Main(string[] args)
        {
            decimal usd = decimal.Parse(Console.ReadLine());

            decimal bgn = usd * 1.79549m;

            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}
