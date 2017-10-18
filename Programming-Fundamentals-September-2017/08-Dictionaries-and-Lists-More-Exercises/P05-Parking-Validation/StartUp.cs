namespace P05_Parking_Validation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var userDatabase = new Dictionary<string, string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCommands; i++)
            {
                string[] currentCommand = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                string currentUsername = currentCommand[1];
                string licensePlate = string.Empty;

                if (currentCommand[0] == "register")
                {
                    licensePlate = currentCommand[2];

                    if (!IsUserRegistered(currentUsername, userDatabase))
                    {
                        string registeredPlate = GetRegLicense(currentUsername, userDatabase);

                        Console.WriteLine($"ERROR: already registered with plate number {registeredPlate}");
                    }
                    else if (!IsLicensePlateValid(licensePlate))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlate}");
                    }
                    else if (!IsLicenseRegistered(licensePlate, userDatabase))
                    {
                        Console.WriteLine($"ERROR: license plate {licensePlate} is busy");
                    }
                    else
                    {
                        if (!userDatabase.ContainsKey(currentUsername))
                        {
                            userDatabase[currentUsername] = licensePlate;
                        }

                        Console.WriteLine($"{currentUsername} registered {licensePlate} successfully");
                    }
                }
                else if (currentCommand[0] == "unregister")
                {
                    if (!userDatabase.ContainsKey(currentUsername))
                    {
                        Console.WriteLine($"ERROR: user {currentUsername} not found");
                    }
                    else
                    {
                        userDatabase.Remove(currentUsername);
                        Console.WriteLine($"user {currentUsername} unregistered successfully");
                    }
                }
            }

            foreach (var user in userDatabase)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        public static bool IsLicensePlateValid(string licensePlate)
        {
            if (licensePlate.Length != 8)
            {
                return false;
            }

            bool isFirstTwoCharactersUpperCase = licensePlate[0] >= 65 && licensePlate[0] <= 90
                                            && licensePlate[1] >= 65 && licensePlate[1] <= 90;

            bool isLastTwoCharactersUpperCase = licensePlate[6] >= 65 && licensePlate[6] <= 90
                                             && licensePlate[7] >= 65 && licensePlate[7] <= 90;

            if (!isFirstTwoCharactersUpperCase || !isLastTwoCharactersUpperCase)
            {
                return false;
            }

            try
            {
                string[] split = Regex.Split(licensePlate, "");

                for (int i = 3; i <= 6; i++)
                {
                    int test = int.Parse(split[i]);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool IsUserRegistered(string userName, Dictionary<string, string> database)
        {
            return !database.ContainsKey(userName);
        }

        public static bool IsLicenseRegistered(string licensePlate, Dictionary<string, string> database)
        {
            return !database.ContainsValue(licensePlate);
        }

        public static string GetRegLicense(string userName, Dictionary<string, string> database)
        {
            string result = string.Empty;

            foreach (var user in database)
            {
                if (user.Key != userName) continue;
                result = user.Value;
                break;
            }

            return result;
        }
    }
}