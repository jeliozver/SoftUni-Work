namespace P14_Boat_Simulator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int moves = int.Parse(Console.ReadLine());

            int firstBoatTiles = 0;
            int secondBoatTiles = 0;

            for (int round = 1; round <= moves; round++)
            {
                if (firstBoatTiles >= 50)
                {
                    Console.WriteLine(firstBoat);
                    return;
                }
                else if (secondBoatTiles >= 50)
                {
                    Console.WriteLine(secondBoat);
                    return;
                }

                string currentMove = Console.ReadLine();

                if (currentMove == "UPGRADE")
                {
                    firstBoat += (char)3;
                    secondBoat += (char)3;
                }
                else if (round % 2 == 0)
                {
                    secondBoatTiles += currentMove.Length;
                }
                else
                {
                    firstBoatTiles += currentMove.Length;
                }
            }

            if (firstBoatTiles > secondBoatTiles)
            {
                Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}