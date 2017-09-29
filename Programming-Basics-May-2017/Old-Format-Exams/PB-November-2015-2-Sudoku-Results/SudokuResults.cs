using System;

namespace PB_November_2015_2_Sudoku_Results
{
    class SudokuResults
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int gamesCount = 0;
            int minutesSum = 0;
            int secondsSum = 0;
            string minutesString = string.Empty;
            string secondsString = string.Empty;

            while (input != "Quit")
            {
                gamesCount++;

                minutesString = (input[0] - 48) + "" + (input[1] - 48) ;
                minutesSum += Convert.ToInt32(minutesString);

                secondsString = (input[3] - 48) + "" + (input[4] - 48);
                secondsSum += Convert.ToInt32(secondsString);

                input = Console.ReadLine();
            }

            double secondsAverage = ((minutesSum * 60) + secondsSum) / (double)gamesCount;

            if (secondsAverage > 1440)
            {
                Console.WriteLine("Bronze Star");
            }
            else if (secondsAverage >= 720 && secondsAverage <= 1440)
            {
                Console.WriteLine("Silver Star");
            }
            else
            {
                Console.WriteLine("Gold Star");
            }

            Console.WriteLine($"Games - {gamesCount} \\ Average seconds - {Math.Ceiling(secondsAverage)}");
        }
    }
}