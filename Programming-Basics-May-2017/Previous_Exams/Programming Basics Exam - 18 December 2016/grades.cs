using System;

namespace PB_Dec_2016_4_Grades
{
    class grades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double gradesFivePlus = 0;
            double gradesFour = 0;
            double gradesThree = 0;
            double gradesFail = 0;
            double averageGradeSum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 5.00)
                {
                    gradesFivePlus++;
                    averageGradeSum += grade;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    gradesFour++;
                    averageGradeSum += grade;
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    gradesThree++;
                    averageGradeSum += grade;

                }
                else if (grade < 3.00)
                {
                    gradesFail++;
                    averageGradeSum += grade;
                }
            }

            double fivePlusPercent = (gradesFivePlus / n ) * 100;
            double fourPercent = (gradesFour / n) * 100;
            double threePercent = (gradesThree / n) * 100;
            double failPercent = (gradesFail/ n) * 100;
            double averageGrade = averageGradeSum / n;

            Console.WriteLine("Top students: {0:f2}%", fivePlusPercent);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", fourPercent);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", threePercent);
            Console.WriteLine("Fail: {0:f2}%", failPercent);
            Console.WriteLine("Average: {0:f2}", averageGrade);
        }
    }
}
