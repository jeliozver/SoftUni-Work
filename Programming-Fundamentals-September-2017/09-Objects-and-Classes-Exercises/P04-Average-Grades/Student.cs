namespace P04_Average_Grades
{
    using System.Linq;

    internal class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }
        public double AverageGrade => Grades.Average();
    }
}