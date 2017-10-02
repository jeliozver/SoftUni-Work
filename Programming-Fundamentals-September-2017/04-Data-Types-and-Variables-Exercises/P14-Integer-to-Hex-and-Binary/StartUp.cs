namespace P14_Integer_to_Hex_and_Binary
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int numToConvert = int.Parse(Console.ReadLine());

            string hexadecimal = Convert.ToString(numToConvert, 16).ToUpper();
            string binary = Convert.ToString(numToConvert, 2);

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}