using System;
namespace PB_MarchM_2_2017_4_Traners_Salary
{
    class tranersSalary
    {
        static void Main(string[] args)
        {
            int lectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double salaryPerLecture = budget / lectures;
            double jelevLectures = 0.0;
            double royalLectures = 0.0;
            double roliLectures = 0.0;
            double trofonLectures = 0.0;
            double sinoLectures = 0.0;
            double othersLectures = 0.0;

            for (int i = 0; i < lectures; i++)
            {
                string name = Console.ReadLine().ToLower();
                if (name != "jelev" && name != "royal" && name != "roli" && name != "trofon" && name != "sino")
                {
                    othersLectures++;
                }
                if (name == "jelev")
                {
                    jelevLectures++;
                }
                else if (name == "royal")
                {
                    royalLectures++;
                }
                else if (name == "roli")
                {
                    roliLectures++;
                }
                else if (name == "trofon")
                {
                    trofonLectures++;
                }
                else if (name == "sino")
                {
                    sinoLectures++;
                }
            }

            double jelevSalary = jelevLectures * salaryPerLecture;
            double royalSalary = royalLectures * salaryPerLecture;
            double roliSalary = roliLectures * salaryPerLecture;
            double trofonSalary = trofonLectures * salaryPerLecture;
            double sinoSalary = sinoLectures * salaryPerLecture;
            double othersSalary = othersLectures * salaryPerLecture;

            Console.WriteLine("Jelev salary: {0:f2} lv", jelevSalary);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royalSalary);
            Console.WriteLine("Roli salary: {0:f2} lv", roliSalary);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofonSalary);
            Console.WriteLine("Sino salary: {0:f2} lv", sinoSalary);
            Console.WriteLine("Others salary: {0:f2} lv", othersSalary);
        }
    }
}
