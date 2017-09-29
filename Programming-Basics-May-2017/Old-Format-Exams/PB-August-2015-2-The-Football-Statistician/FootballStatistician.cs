using System;
using System.Text.RegularExpressions;

namespace PB_August_2015_2_The_Football_Statistician
{
    class FootballStatistician
    {
        static void Main(string[] args)
        {
            decimal payment = decimal.Parse(Console.ReadLine());
            string currentGame = Console.ReadLine();

            int gamesPlayed = 0;
            int arsenalPoints = 0;
            int chelseaPoints = 0;
            int evertonPoints = 0;
            int liverpoolPoints = 0;
            int manCityPoints = 0;
            int manUnitedPoints = 0;
            int southhamptonPoints = 0;
            int tottenhamPoints = 0;

            while (currentGame != "End of the league.")
            {
                gamesPlayed++;
                string currentGameNoExtraSpace = Regex.Replace(currentGame, " {2,}", " ");
                string[] parameters = currentGameNoExtraSpace.Split();
                string teamOne = parameters[0];
                string result = parameters[1];
                string teamTwo = parameters[2];
                int teamOnePoints = 0;
                int teamTwoPoints = 0;

                switch (result)
                {
                    case "1": teamOnePoints = 3; break;
                    case "2": teamTwoPoints = 3; break;
                    case "X": teamOnePoints = 1; teamTwoPoints = 1; break;
                }
                
                switch (teamOne)
                {
                    case "Arsenal": arsenalPoints += teamOnePoints; break;
                    case "Chelsea": chelseaPoints += teamOnePoints; break;
                    case "Everton": evertonPoints += teamOnePoints; break;
                    case "Liverpool": liverpoolPoints += teamOnePoints; break;
                    case "ManchesterCity": manCityPoints += teamOnePoints; break;
                    case "ManchesterUnited": manUnitedPoints += teamOnePoints; break;
                    case "Southampton": southhamptonPoints += teamOnePoints; break;
                    case "Tottenham": tottenhamPoints += teamOnePoints; break;
                }

                switch (teamTwo)
                {
                    case "Arsenal": arsenalPoints += teamTwoPoints; break;
                    case "Chelsea": chelseaPoints += teamTwoPoints; break;
                    case "Everton": evertonPoints += teamTwoPoints; break;
                    case "Liverpool": liverpoolPoints += teamTwoPoints; break;
                    case "ManchesterCity": manCityPoints += teamTwoPoints; break;
                    case "ManchesterUnited": manUnitedPoints += teamTwoPoints; break;
                    case "Southampton": southhamptonPoints += teamTwoPoints; break;
                    case "Tottenham": tottenhamPoints += teamTwoPoints; break;
                }

                currentGame = Console.ReadLine();
            }

            decimal moneyInLeva = (payment * gamesPlayed) * 1.94m;

            Console.WriteLine($"{moneyInLeva:f2}lv.");
            Console.WriteLine($"Arsenal - {arsenalPoints} points.");
            Console.WriteLine($"Chelsea - {chelseaPoints} points.");
            Console.WriteLine($"Everton - {evertonPoints} points.");
            Console.WriteLine($"Liverpool - {liverpoolPoints} points.");
            Console.WriteLine($"Manchester City - {manCityPoints} points.");
            Console.WriteLine($"Manchester United - {manUnitedPoints} points.");
            Console.WriteLine($"Southampton - {southhamptonPoints} points.");
            Console.WriteLine($"Tottenham - {tottenhamPoints} points.");
        }
    }
}