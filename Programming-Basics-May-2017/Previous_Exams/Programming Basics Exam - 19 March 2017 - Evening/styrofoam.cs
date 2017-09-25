using System;

namespace PB_MarchE_2_2017_2_Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            int windowsNum = int.Parse(Console.ReadLine());
            double sqmStyrofoamPkg = double.Parse(Console.ReadLine());
            double StyrofoamPkgPrice = double.Parse(Console.ReadLine());

            double area2Cover = houseArea - (windowsNum * 2.4);
            double spoilage = area2Cover + (area2Cover * 0.10);
            double pkgReq = Math.Ceiling(spoilage / sqmStyrofoamPkg);
            double price = pkgReq * StyrofoamPkgPrice;

            if (budget >= price)
            {
                Console.WriteLine("Spent: {0:f2}", price);
                Console.WriteLine("Left: {0:f2}", budget - price);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", price - budget);
            }
        }
    }
}