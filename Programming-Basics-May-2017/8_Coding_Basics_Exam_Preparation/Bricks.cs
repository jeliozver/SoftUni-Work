using System;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            double numBricks = double.Parse(Console.ReadLine());
            double numWorkers = double.Parse(Console.ReadLine());
            double sizeCart = double.Parse(Console.ReadLine());

            double bricksPerRun = numWorkers * sizeCart;
            double minRuns = numBricks / bricksPerRun;

            Console.WriteLine(Math.Ceiling(minRuns));
        }
    }
}
