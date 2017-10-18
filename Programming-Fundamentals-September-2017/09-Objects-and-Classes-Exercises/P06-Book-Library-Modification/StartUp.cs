namespace P06_Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfEnties = int.Parse(Console.ReadLine());

            var library = new Library
            {
                Name = "GitGud",
                Books = new List<Book>()
            };

            for (int i = 0; i < numberOfEnties; i++)
            {
                var currentBook = GetBookInfo();
                library.Books.Add(currentBook);
            }

            var titlesAferDate = new Dictionary<string, DateTime>();
            string format = "dd.MM.yyyy";

            var startDate = DateTime.ParseExact(Console.ReadLine(),
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

            foreach (var title in result)
            {
                Console.WriteLine($"{title.Key} -> {title.Value:dd.MM.yyy}");
            }
        }

        private static Book GetBookInfo()
        {
            string[] currentInfo = Console.ReadLine()
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

            return book;
        }
    }
}