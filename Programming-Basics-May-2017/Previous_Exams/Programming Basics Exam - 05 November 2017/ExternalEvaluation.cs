namespace PB_November_2017_4_External_Evaluation
{
    using System;

    public class ExternalEvaluation
    {
        public static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());

            double poorMarks = 0;
            double satisfactoryMarks = 0;
            double goodMarks = 0;
            double veryGoodMarks = 0;
            double excellentMarks = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                double currentMark = double.Parse(Console.ReadLine());

                if (currentMark >= 76.5 && currentMark <= 100)
                {
                    excellentMarks++;
                }
                else if (currentMark >= 58.5 && currentMark <= 76.5)
                {
                    veryGoodMarks++;
                }
                else if (currentMark >= 40.5 && currentMark <= 58.5)
                {
                    goodMarks++;
                }
                else if (currentMark >= 22.5 && currentMark <= 40.5)
                {
                    satisfactoryMarks++;
                }
                else
                {
                    poorMarks++;
                }
            }

            Console.WriteLine($"{poorMarks / studentsCount * 100.0:f2}% poor marks");
            Console.WriteLine($"{satisfactoryMarks / studentsCount * 100.0:f2}% satisfactory marks");
            Console.WriteLine($"{goodMarks / studentsCount * 100.0:f2}% good marks");
            Console.WriteLine($"{veryGoodMarks / studentsCount * 100.0:f2}% very good marks");
            Console.WriteLine($"{excellentMarks / studentsCount * 100.0:f2}% excellent marks");
        }
    }
}