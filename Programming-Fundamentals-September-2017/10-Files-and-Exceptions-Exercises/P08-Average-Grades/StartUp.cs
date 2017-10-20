namespace P08_Average_Grades
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllLines("Input.txt");
            int lastIndex = 0;
            var studentsList = new List<Student>();

            int studentsCount = int.Parse(input[lastIndex++]);
 

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentInfo = input[lastIndex++]
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

            var result = new List<string>();

            foreach (var student in studentsFiltered)
            {
                result.Add($"{student.Name} -> {student.AverageGrade:f2}");
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}