namespace P09_Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var teams = AddTeamsInfo();
            teams = AddMembersInfo(teams);

            var teamsOrdered = teams
                .OrderByDescending(c => c.TeamMembers.Count)
                .ThenBy(m => m.TeamName).ToList();

            var teamsRemaining = new List<Team>();
            var teamsDisbanded = new List<string>();

            foreach (var team in teamsOrdered)
            {
                if (team.TeamMembers.Count != 0)
                {
                    teamsRemaining.Add(team);
                }
                else
                {
                    teamsDisbanded.Add(team.TeamName);
                }
            }

            PrintTeams(teamsRemaining, teamsDisbanded);
        }

        private static List<Team> AddTeamsInfo()
        {
            var teams = new List<Team>();

            int teamsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsCount; i++)
            {
                string[] currentTeam = Console.ReadLine()
                    .Split('-')
                    .ToArray();

                string currentCreator = currentTeam[0];
                string currentTeamName = currentTeam[1];

                var team = new Team
                {
                    TeamCreator = currentCreator,
                    TeamName = currentTeamName,
                    TeamMembers = new List<string>()
                };

                if (teams.Any(n => n.TeamName == currentTeamName))
                {
                    Console.WriteLine($"Team {currentTeamName} was already created!");
                }
                else if (teams.Any(c => c.TeamCreator == currentCreator))
                {
                    Console.WriteLine($"{currentCreator} cannot create another team!");
                }
                else
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {currentTeamName} has been created by {currentCreator}!");
                }
            }

            return teams;
        }

        private static List<Team> AddMembersInfo(List<Team> teams)
        {
            string joinRequest = Console.ReadLine();

            while (joinRequest != "end of assignment")
            {
                string[] arguments = joinRequest
                    .Split('-', '>')
                    .ToArray();

                string member = arguments[0];
                string teamToJoin = arguments[2];

                if (teams.All(n => n.TeamName != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (teams.Any(n => n.TeamMembers.Any(m => m.Equals(member))) ||
                         teams.Any(n => n.TeamCreator.Equals(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                }
                else
                {
                    foreach (var team in teams)
                    {
                        if (team.TeamName == teamToJoin)
                        {
                            team.TeamMembers.Add(member);
                            team.TeamMembers.Sort();
                            break;
                        }
                    }
                }

                joinRequest = Console.ReadLine();
            }

            return teams;
        }

        private static void PrintTeams(List<Team> teamsRemaining, List<string> teamsDisbanded)
        {
            foreach (var team in teamsRemaining)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.TeamCreator}");

                foreach (var member in team.TeamMembers)
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teamsDisbanded)
            {
                Console.WriteLine($"{team}");
            }
        }
    }
}