namespace P02_Hogwarts_Sorting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var students = new List<string>();
            var houses = new Dictionary<string, int>();
            {
                houses["Gryffindor"] = 0;
                houses["Slytherin"] = 0;
                houses["Ravenclaw"] = 0;
                houses["Hufflepuff"] = 0;
            }

            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                string firstName = args[0];
                string lastName = args[1];
                long sum = firstName.Sum(ch => ch) + lastName.Sum(ch => ch);

                string facultyNumber = sum.ToString() + firstName[0] + lastName[0];
                string house = string.Empty;

                if (sum % 4 == 0)
                {
                    house = "Gryffindor";
                }
                else if (sum % 4 == 1)
                {
                    house = "Slytherin";
                }
                else if (sum % 4 == 2)
                {
                    house = "Ravenclaw";
                }
                else if (sum % 4 == 3)
                {
                    house = "Hufflepuff";
                }

                string result = house + " " + facultyNumber;
                students.Add(result);

                houses[house]++;
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            foreach (var house in houses)
            {
                Console.WriteLine($"{house.Key}: {house.Value}");
            }
        }
    }
}