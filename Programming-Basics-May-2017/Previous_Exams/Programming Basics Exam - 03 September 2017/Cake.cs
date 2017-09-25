using System;

namespace PB_Sep_2017_4_Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeHeight = int.Parse(Console.ReadLine());
            string piecesTaken = Console.ReadLine();

            int piecesAll = cakeHeight * cakeWidth;

            int piecesTakenAll = 0;
            int piecesLeft = piecesAll;

            piecesLeft -= Convert.ToInt32(piecesTaken);
            piecesTakenAll += Convert.ToInt32(piecesTaken);

            while (piecesTaken != "STOP" || piecesLeft < 0)
            {
                if (piecesLeft < 0)
                {
                    int piecesNeeded = piecesTakenAll - piecesAll;
                    Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
                    return;
                }
                else
                {
                    piecesTaken = Console.ReadLine();
                    if (piecesTaken == "STOP")
                    {

                    }
                    else
                    {
                        piecesTakenAll += Convert.ToInt32(piecesTaken);
                        piecesLeft -= Convert.ToInt32(piecesTaken);
                    }
                }
            }

            Console.WriteLine($"{piecesLeft} pieces are left.");
        }
    }
}