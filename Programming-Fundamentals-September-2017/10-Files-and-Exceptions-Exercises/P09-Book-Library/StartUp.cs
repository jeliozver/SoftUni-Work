namespace P09_Book_Library
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = File.ReadAllLines("Input.txt");
            var library = AddBooksIntoLibrary(input);
            var pricesByAuthors = new Dictionary<string, decimal>();

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

            var output = new List<string>();

            foreach (var author in result)
            {
                output.Add($"{author.Key} -> {author.Value:f2}");
            }

            File.WriteAllLines("Output.txt", output);
        }

        public static Library AddBooksIntoLibrary(string[] input)
        {
            var library = new Library
            {
                Name = "GGWP",
                Books = new List<Book>()
            };

            int lastIndex = 0;
            int numberOfBooks = int.Parse(input[lastIndex++]);

            for (int i = 0; i < numberOfBooks; i++)
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