namespace P08_Mentor_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var students = new Dictionary<string, StudentData>();

            string currentDate = Console.ReadLine();

            while (currentDate != "end of dates")
            {
                string[] arguments = currentDate
                    .Split(' ', ',')
                    .ToArray();

                string name = arguments[0];
                string[] datesArray = arguments
                    .Skip(1)
                    .ToArray();

                if (!students.ContainsKey(name))
                {
                    students[name] = new StudentData
                    {
                        Comments = new List<string>(),
                        Dates = new List<string>()
                    };
                }

                students[name].Dates.InsertRange(0, datesArray);
                students[name].Dates.Sort();

                currentDate = Console.ReadLine();
            }

            string currentComment = Console.ReadLine();

            while (currentComment != "end of comments")
            {
                string[] arguments = currentComment
                    .Split('-')
                    .ToArray();

                string name = arguments[0];
                string comment = arguments[1];

                if (students.ContainsKey(name))
                {
                    students[name].Comments.Add(comment);
                }

                currentComment = Console.ReadLine();
            }

            var studentsSorted = students
                 .OrderBy(n => n.Key)
                 .ToList();

            foreach (var student in studentsSorted)
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");

                foreach (var comment in student.Value.Comments)
                {
                    if (student.Value.Comments.Count != 0)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.Value.Dates)
                {
                    if (student.Value.Dates.Count != 0)
                    {
                        Console.WriteLine($"-- {date}");
                    }
                }
            }
        }
    }
}