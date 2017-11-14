namespace P03_Matrix_Operator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            var pseudoMatrix = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                string currentRow = Console.ReadLine();
                pseudoMatrix.Add(currentRow);
            }

            string currentCommand = Console.ReadLine();

            while (currentCommand != "end")
            {
                string[] args = currentCommand
                    .Split(' ')
                    .ToArray();

                string opperand = args[0];

                switch (opperand)
                {
                    case "remove":
                        pseudoMatrix = RemoveElements(args, pseudoMatrix);
                        break;

                    case "swap":
                        pseudoMatrix = SwapRows(args, pseudoMatrix);
                        break;

                    case "insert":
                        pseudoMatrix = InsertElement(args, pseudoMatrix);
                        break;
                }

                currentCommand = Console.ReadLine();
            }

            foreach (var row in pseudoMatrix)
            {
                Console.WriteLine(row);
            }
        }

        public static List<string> RemoveElements(string[] args, List<string> pseudoMatrix)
        {
            string type = args[1];
            string position = args[2];
            int index = int.Parse(args[3]);

            switch (position)
            {
                case "row":
                    if (pseudoMatrix[index] == string.Empty) return pseudoMatrix;
                    var row = pseudoMatrix[index]
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();
                    var builder = new StringBuilder();

                    switch (type)
                    {
                        case "positive":
                            foreach (var num in row)
                            {
                                if (num >= 0) continue;
                                builder.Append(num);
                                builder.Append(" ");
                            }
                            break;

                        case "negative":
                            foreach (var num in row)
                            {
                                if (num < 0) continue;
                                builder.Append(num);
                                builder.Append(" ");
                            }
                            break;

                        case "even":
                            foreach (var num in row)
                            {
                                if (num % 2 == 0) continue;
                                builder.Append(num);
                                builder.Append(" ");
                            }
                            break;

                        case "odd":
                            foreach (var num in row)
                            {
                                if (num % 2 != 0) continue;
                                builder.Append(num);
                                builder.Append(" ");
                            }
                            break;
                    }

                    pseudoMatrix[index] = builder.ToString().TrimEnd(' ');
                    break;

                case "col":
                    switch (type)
                    {
                        case "positive":
                        case "negative":
                        case "even":
                        case "odd":
                            pseudoMatrix = RemoveColElements(pseudoMatrix, type, index);
                            break;
                    }
                    break;
            }

            return pseudoMatrix;
        }

        private static List<string> RemoveColElements(List<string> pseudoMatrix, string type, int index)
        {
            var result = new List<string>();

            foreach (string row in pseudoMatrix)
            {
                if (row == string.Empty)
                {
                    result.Add(row);
                    continue;
                }

                var currentRow = row
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                if (index < 0 || index > currentRow.Length - 1)
                {
                    result.Add(row);
                    continue;
                }

                var builder = new StringBuilder();

                for (int i = 0; i < currentRow.Length; i++)
                {
                    if (i == index)
                    {
                        if (type == "positive")
                        {
                            if (currentRow[i] < 0)
                            {
                                builder.Append(currentRow[i]);
                                builder.Append(" ");
                            }
                        }
                        else if (type == "negative")
                        {
                            if (currentRow[i] >= 0)
                            {
                                builder.Append(currentRow[i]);
                                builder.Append(" ");
                            }
                        }
                        else if (type == "even")
                        {
                            if (currentRow[i] % 2 !=0)
                            {
                                builder.Append(currentRow[i]);
                                builder.Append(" ");
                            }
                        }
                        else if (type == "odd")
                        {
                            if (currentRow[i] % 2 == 0)
                            {
                                builder.Append(currentRow[i]);
                                builder.Append(" ");
                            }
                        }
                    }
                    else
                    {
                        builder.Append(currentRow[i]);
                        builder.Append(" ");
                    }
                }

                result.Add(builder.ToString().TrimEnd(' '));
            }

            return result;
        }

        public static List<string> SwapRows(string[] args, List<string> pseudoMatrix)
        {
            int firstRowIndex = int.Parse(args[1]);
            int secondRowIndex = int.Parse(args[2]);

            string rowOneNew = pseudoMatrix[secondRowIndex];
            string rowTwoNew = pseudoMatrix[firstRowIndex];

            pseudoMatrix[firstRowIndex] = rowOneNew;
            pseudoMatrix[secondRowIndex] = rowTwoNew;

            return pseudoMatrix;
        }

        public static List<string> InsertElement(string[] args, List<string> pseudoMatrix)
        {
            int rowIndex = int.Parse(args[1]);
            int element = int.Parse(args[2]);

            string newRow = pseudoMatrix[rowIndex];
            newRow = element + " " + newRow;
            pseudoMatrix[rowIndex] = newRow;

            return pseudoMatrix;
        }
    }
}