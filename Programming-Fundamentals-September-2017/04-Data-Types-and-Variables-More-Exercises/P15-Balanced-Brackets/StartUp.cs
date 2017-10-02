namespace P15_Balanced_Brackets
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string lastBracket = string.Empty;
            string balanceState = "BALANCED";

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (lastBracket == "(")
                    {
                        balanceState = "UNBALANCED";
                        Console.WriteLine(balanceState);
                        return;
                    }

                    lastBracket = "(";
                }

                if (input == ")")
                {
                    if (lastBracket != "(")
                    {
                        balanceState = "UNBALANCED";
                        Console.WriteLine(balanceState);
                        return;
                    }

                    lastBracket = ")";
                }
            }

            if (lastBracket != ")")
            {
                balanceState = "UNBALANCED";
            }

            Console.WriteLine(balanceState);
        }
    }
}