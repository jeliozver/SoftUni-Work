namespace P11_String_Concatenation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char delimeter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (oddOrEven == "even")
                {
                    if (i % 2 == 0)
                    {
                        result += "" + input + delimeter;
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        result += "" + input + delimeter;
                    }
                }
            }

            string resultFormat = result.Remove(result.Length - 1);

            Console.WriteLine(resultFormat);
        }
    }
}