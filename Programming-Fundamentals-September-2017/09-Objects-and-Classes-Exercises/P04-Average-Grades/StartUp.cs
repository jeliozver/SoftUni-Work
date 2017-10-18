namespace P04_Average_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var studentsList = new List<Student>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                double[] studentGrades = studentInfo
                    .Skip(1)
                    .Select(double.Parse)
                    .ToArray();

                var currentStudent = new Student
                {
                    Name = studentInfo[0],
                    Grades = studentGrades
                };

                studentsList.Add(currentStudent);
            }

            var studentsFiltered = studentsList
                .Where(avg => avg.AverageGrade >= 5.00)
                .OrderBy(n => n.Name)
                .ThenByDescending(g => g.AverageGrade)
                .ToList();

            foreach (var student in studentsFiltered)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}