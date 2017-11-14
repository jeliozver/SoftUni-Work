namespace P02_Game_of_Names
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int playersCount = int.Parse(Console.ReadLine());

            string winner = string.Empty;
            int winnerScore = int.MinValue;

            for (int i = 0; i < playersCount; i++)
            {
                string playerName = Console.ReadLine();
                int playerScore = int.Parse(Console.ReadLine());

                for (int j = 0; j < playerName.Length; j++)
                {
                    if (playerName[j] % 2 == 0)
                    {
                        playerScore += playerName[j];
                    }
                    else
                    {
                        playerScore -= playerName[j];
                    }
                }

                if (playerScore > winnerScore)
                {
                    winner = playerName;
                    winnerScore = playerScore;
                }
            }

            Console.WriteLine($"The winner is {winner} - {winnerScore} points");
        }
    }
}