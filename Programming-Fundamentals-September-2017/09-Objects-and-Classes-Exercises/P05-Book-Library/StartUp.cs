namespace P05_Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            var library = new Library
            {
                Name = "GGWP",
                Books = new List<Book>()
            };

            var pricesByAuthors = new Dictionary<string, decimal>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                var currentBook = GetBookInfo();
                library.Books.Add(currentBook);
            }

            foreach (var book in library.Books)
            {
                if (!pricesByAuthors.ContainsKey(book.Author))
                {
                    pricesByAuthors[book.Author] = 0m;
                }

                pricesByAuthors[book.Author] += book.Price;
            }

            var result = pricesByAuthors
                .OrderByDescending(p => p.Value)
                .ThenBy(a => a.Key)
                .ToArray();

            foreach (var author in result)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
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