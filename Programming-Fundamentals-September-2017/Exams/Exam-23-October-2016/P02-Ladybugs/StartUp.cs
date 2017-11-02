namespace P02_Ladybugs
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            short fieldSize = short.Parse(Console.ReadLine());
            int[] ladyBugIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            // Array of ints with size of the field. All indexes are 0 by default
            int[] ladyBugs = new int[fieldSize];

            // Start populating the array with ladybugs
            foreach (int index in ladyBugIndexes)
            {
                // If the given index is inside the field the value of the given index is set to 1
                // If the given index is outside the field we continue reading
                if (index < 0 || index > ladyBugs.Length - 1) continue;
                ladyBugs[index] = 1;
            }

            // Start getting the commands until the command equals "end"
            string currentCommand = Console.ReadLine();

            while (currentCommand != "end")
            {
                // Get the command arguments
                string[] args = currentCommand
                    .Split(' ')
                    .ToArray();

                int ladyBugIndex = int.Parse(args[0]);
                string flyDirection = args[1];
                int flyLenght = int.Parse(args[2]);

                //If the given ladybug index is outside of the field of if the move is 0 we read a new command
                if (ladyBugIndex < 0 || ladyBugIndex > ladyBugs.Length - 1 || flyLenght == 0)
                {
                    currentCommand = Console.ReadLine();
                    continue;
                }
                // If the given ladybug index does not have a ladybug there we read a new command
                if (ladyBugs[ladyBugIndex] == 0)
                {
                    currentCommand = Console.ReadLine();
                    continue;
                }

                if (flyDirection == "right")
                {
                    while (true)
                    {
                        // If the given lenght gets the ladyBug outside the field we change the index value to 0
                        // Notice that if the given lenght is a negative number the move actually switches to the other side
                        // so we need to check for both ways
                        if (ladyBugIndex + flyLenght > ladyBugs.Length - 1 || ladyBugIndex + flyLenght < 0)
                        {
                            ladyBugs[ladyBugIndex] = 0;
                            break;
                        }
                        // If after the move the landzone is free (value is 0) ladyug can safely land
                        // then we change ladubug's last position to 0 and set its new possition to l
                        if (ladyBugs[ladyBugIndex + flyLenght] == 0)
                        {
                            ladyBugs[ladyBugIndex] = 0;
                            ladyBugs[ladyBugIndex + flyLenght] = 1;
                            break;
                        }

                        // If we get to here then the index we try to fly to is occupied by another ladybug
                        // so we double the fly lenght and try again
                        flyLenght += flyLenght;
                    }
                }
                else if (flyDirection == "left")
                {
                    // Same logic as with the other direction, but here we subtract instead
                    while (true)
                    {
                        if (ladyBugIndex - flyLenght > ladyBugs.Length - 1 || ladyBugIndex - flyLenght < 0)
                        {
                            ladyBugs[ladyBugIndex] = 0;
                            break;
                        }

                        if (ladyBugs[ladyBugIndex - flyLenght] == 0)
                        {
                            ladyBugs[ladyBugIndex] = 0;
                            ladyBugs[ladyBugIndex - flyLenght] = 1;
                            break;
                        }

                        // We still double the fly lenght and try again
                        flyLenght += flyLenght;
                    }
                }

                // Read new command
                currentCommand = Console.ReadLine();
            }

            // Finally we print the result array
            Console.WriteLine(string.Join(" ", ladyBugs));
        }
    }
}