using System;

namespace PB_NovE_2016_1_House_Price
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            double firstRoomArea = double.Parse(Console.ReadLine());
            double citchenArea = double.Parse(Console.ReadLine());
            double squareMeterPrice = double.Parse(Console.ReadLine());

            double secondRoomArea = firstRoomArea + (firstRoomArea * 0.10);
            double thirdRoomArea = secondRoomArea + (secondRoomArea * 0.10);
            double bathRoomArea = firstRoomArea / 2;
            double totalArea = firstRoomArea + secondRoomArea + thirdRoomArea + + citchenArea + bathRoomArea;
            double totalAreaHallway = totalArea + (totalArea * 0.05);
            double finalPrice = totalAreaHallway * squareMeterPrice;

            Console.WriteLine("{0:F2}", finalPrice);
        }
    }
}
