namespace P01_Order_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var personsList = new List<PersonInfo>();

            string currentInput = Console.ReadLine();

            while (currentInput != "End")
            {
                string[] arguments = currentInput
                    .Split(' ')
                    .ToArray();

                var currentPerson = new PersonInfo
                {
                    Name = arguments[0],
                    Id = arguments[1],
                    Age = int.Parse(arguments[2])
                };

                personsList.Add(currentPerson);

                currentInput = Console.ReadLine();
            }

            foreach (var person in personsList.OrderBy(age => age.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}