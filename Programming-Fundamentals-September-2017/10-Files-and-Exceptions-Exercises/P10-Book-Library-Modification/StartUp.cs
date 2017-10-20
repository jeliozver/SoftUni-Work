namespace P10_Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllLines("Input.txt");
            var library = AddBooksIntoLibrary(input);

            var titlesAferDate = new Dictionary<string, DateTime>();
            string format = "dd.MM.yyyy";

            var startDate = DateTime.ParseExact(input[input.Length - 1],
                format, CultureInfo.InvariantCulture);

            foreach (var book in library.Books)
            {
                if (!titlesAferDate.ContainsKey(book.Title) && book.ReleaseDate > startDate)
                {
                    titlesAferDate[book.Title] = book.ReleaseDate;
                }
            }

            var result = titlesAferDate
                .OrderBy(d => d.Value)
                .ThenBy(t => t.Key)
                .ToArray();

            var output = new List<string>();

            foreach (var title in result)
            {
                output.Add($"{title.Key} -> {title.Value:dd.MM.yyy}");
            }

            File.WriteAllLines("Output.txt", output);
        }

        public static Library AddBooksIntoLibrary(string[] input)
        {
            var library = new Library
            {
                Name = "GitGud",
                Books = new List<Book>()
            };

            int lastIndex = 0;
            int numberOfEnties = int.Parse(input[lastIndex++]);

            for (int i = 0; i < numberOfEnties; i++)
            {
                string[] currentInfo = input[lastIndex++]
                    .Split(' ')
                    .ToArray();

                var book = new Book
                {
                    Title = currentInfo[0],
                    Author = currentInfo[1],
                    Publisher = currentInfo[2],
                    ReleaseDate = DateTime
                        .ParseExact(currentInfo[3]
                            , "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = currentInfo[4],
                    Price = decimal.Parse(currentInfo[5])
                };

                library.Books.Add(book);
            }

            return library;
        }
    }
}