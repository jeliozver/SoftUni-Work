namespace P04_Variable_in_Hex_Format
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string hexadecimalInput = Console.ReadLine();

            int decimalOutput = Convert.ToInt32(hexadecimalInput, 16);

            Console.WriteLine(decimalOutput);
        }
    }
}
