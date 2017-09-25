using System;

namespace PB_March_2016_3_On_Time_for_the_Exam
{
    class onTimeforTheExam
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arrivalH = int.Parse(Console.ReadLine());
            int arrivalM = int.Parse(Console.ReadLine());

            // Convert time from HH:MM to MM
            int examTimeM = (examH * 60) + examM;
            int arrivalTimeM = (arrivalH * 60) + arrivalM;

            // Check if times are the same
            if (examTimeM == arrivalTimeM)
            {
                Console.WriteLine("On time");
            }

            // Check if late
            else if (arrivalTimeM > examTimeM)
            {
                int timeDiffM = arrivalTimeM - examTimeM;
                // Loop to convert time back to HH:MM
                int timeDiffH = 0;
                while (timeDiffM >= 60)
                {
                    timeDiffM -= 60;
                    timeDiffH ++;
                }

                if (timeDiffH >= 1 && timeDiffM < 10)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:0{1} hours after the start", timeDiffH, timeDiffM);
                }
                else if (timeDiffH >= 1)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1} hours after the start", timeDiffH, timeDiffM);
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", timeDiffM);
                }
            }

            // Check if Early
            else if (examTimeM - arrivalTimeM > 30)
            {
                int timeDiffM = examTimeM - arrivalTimeM;
                // Loop to convert time back to HH:MM
                int timeDiffH = 0;
                while (timeDiffM >= 60)
                {
                    timeDiffM -= 60;
                    timeDiffH ++;
                }
                if (timeDiffH >= 1 && timeDiffM < 10)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:0{1} hours before the start", timeDiffH, timeDiffM);
                }
                else if (timeDiffH >= 1)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1} hours before the start", timeDiffH, timeDiffM);
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", timeDiffM);
                }
            }

            // Check if On time
            else if (examTimeM - arrivalTimeM <= 30)
            {
                int timeDiffM = examTimeM - arrivalTimeM;
                // Loop to convert time back to HH:MM
                int timeDiffH = 0;
                while (timeDiffM >= 60)
                {
                    timeDiffM -= 60;
                    timeDiffH ++;
                }
                if (timeDiffH >= 1 && timeDiffM < 10)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0}:0{1} hours before the start", timeDiffH, timeDiffM);
                }
                else if (timeDiffH >= 1)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0}:{1} hours before the start", timeDiffH, timeDiffM);
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", timeDiffM);
                }
            }         
        }
    }
}
