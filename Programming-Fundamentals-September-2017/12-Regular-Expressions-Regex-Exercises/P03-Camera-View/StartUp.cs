namespace P03_Camera_View
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine();

            int skipElements = numbers[0];
            int takeElements = numbers[1];
            string pattern = @"\|<\w+";

            var camerasMatches = Regex
                .Matches(text, pattern);

            var cameraList = (from Match camera
                              in camerasMatches
                              select camera.Value)
                              .ToArray();

            var viewsList = new List<string>();

            foreach (string view in cameraList)
            {
                string currentView = view;

                currentView = currentView.Replace("|<", "");

                var filter = currentView
                    .ToCharArray()
                    .Skip(skipElements)
                    .Take(takeElements);

                string result = string.Join("", filter);
                viewsList.Add(result);
            }

            Console.WriteLine(string.Join(", ", viewsList));
        }
    }
}