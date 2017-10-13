namespace P06_User_Logs
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string currentLog = Console.ReadLine();

            var usersLog = new SortedDictionary<string, Dictionary<string, int>>();

            while (currentLog != "end")
            {
                string[] arguments = currentLog.Split('=', ' ');

                string currentIp = arguments[1];
                string currentUser = arguments[5];

                if (!usersLog.ContainsKey(currentUser))
                {
                    usersLog[currentUser] = new Dictionary<string, int>();
                }

                if (!usersLog[currentUser].ContainsKey(currentIp))
                {
                    usersLog[currentUser].Add(currentIp, 0);
                }

                usersLog[currentUser][currentIp]++;

                currentLog = Console.ReadLine();
            }

            foreach (var user in usersLog)
            {
                List<string> result = new List<string>();

                Console.WriteLine($"{user.Key}: ");

                foreach (var ip in usersLog[user.Key])
                {
                    result.Add($"{ip.Key} => {ip.Value}");
                }

                Console.WriteLine($"{string.Join(", ", result)}.");
            }
        }
    }
}