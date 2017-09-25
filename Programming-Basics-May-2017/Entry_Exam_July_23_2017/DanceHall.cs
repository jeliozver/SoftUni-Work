using System;

namespace _01_Dance_Hall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            double hallLenght = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double hallSize = (hallLenght * 100) * (hallWidth * 100);
            double wardrobeSize = (wardrobeSide * 100) * (wardrobeSide * 100);
            double benchSize = hallSize / 10;
            double freeSpace = hallSize - wardrobeSize - benchSize;
            double dancersCount = Math.Floor(freeSpace / (40 + 7000));

            Console.WriteLine(dancersCount);
        }
    }
}
