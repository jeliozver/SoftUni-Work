using System;

namespace Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string result = Console.ReadLine();

                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }
                else
                {

                }
            }
        }

        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }

        static void ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");

            if (code >= 0)
            {
                Console.WriteLine("Reason: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine("Reason: Internal System Failure.");
            }
        }
    }
}