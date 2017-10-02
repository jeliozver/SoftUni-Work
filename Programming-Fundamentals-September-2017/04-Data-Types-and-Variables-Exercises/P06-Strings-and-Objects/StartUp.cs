namespace P06_Strings_and_Objects
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string toPrint = (string)helloWorld;

            Console.WriteLine(toPrint);
        }
    }
}
