using System;

namespace Hello_Name
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            HelloSomeone(name);
        }

        static void HelloSomeone(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}