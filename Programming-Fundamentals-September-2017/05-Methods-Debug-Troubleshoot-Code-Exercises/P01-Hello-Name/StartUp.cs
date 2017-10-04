namespace P01_Hello_Name
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine(GetName(name));
        }

        private static string GetName(string name)
        {
            string printName = $"Hello, {name}!";
            return printName;
        }
    }
}