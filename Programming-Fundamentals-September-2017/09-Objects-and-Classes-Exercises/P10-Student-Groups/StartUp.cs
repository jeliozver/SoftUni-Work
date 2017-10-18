namespace P10_Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var towns = ReadTownsAndStudents();
            var groups = DistributeIntoGroups(towns);
            PrintGroup(groups, towns);
        }

        private static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();

            string inputLine = Console.ReadLine();
            string lastTown = string.Empty;

            while (inputLine != "End")
            {
                if (inputLine.Contains("=>"))
                {
                    string[] arguments = Regex.Split(inputLine, " => ");
                    string seats = arguments[1];
                    string[] seatsNumber = Regex.Split(seats, " seats");

                    lastTown = arguments[0];
                    int seatsCout = int.Parse(seatsNumber[0]);

                    var town = new Town
                    {
                        Name = lastTown,
                        SeatsCount = seatsCout,
                        Students = new List<Student>()
                    };

                    towns.Add(town);
                }
                else
                {
                    string[] arguments = inputLine
                        .Split('|')
                        .ToArray();

                    string name = arguments[0].TrimStart().TrimEnd();
                    string email = arguments[1].TrimStart().TrimEnd();
                    string date = arguments[2].TrimStart().TrimEnd();
                    var dateformat = DateTime
                        .ParseExact(date, "d-MMM-yyyy",
                        CultureInfo.InvariantCulture);

                    var student = new Student
                    {
                        Name = name,
                        Email = email,
                        RegisterDate = dateformat
                    };

                    foreach (var town in towns)
                    {
                        if (town.Name == lastTown)
                        {
                            town.Students.Add(student);
                            break;
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            return towns;
        }

        private static List<Group> DistributeIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns)
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(d => d.RegisterDate)
                    .ThenBy(n => n.Name)
                    .ThenBy(e => e.Email);

                while (students.Any())
                {
                    var group = new Group();

                    group.Town = town;
                    group.Students = students
                        .Take(group.Town.SeatsCount)
                        .ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }

        private static void PrintGroup(List<Group> groups, List<Town> towns)
        {
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

            var groupsOrdered = groups
                .OrderBy(n => n.Town.Name)
                .ToList();

            foreach (var group in groupsOrdered)
            {
                var currentEmails = group
                    .Students
                    .Select(student => student.Email)
                    .ToList();

                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", currentEmails)}");
            }
        }
    }
}