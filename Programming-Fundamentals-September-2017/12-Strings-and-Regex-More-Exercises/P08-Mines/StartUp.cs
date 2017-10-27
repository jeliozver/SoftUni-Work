namespace P08_Mines
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string mineField = Console.ReadLine();

            string minePattern = @"<([\w{1}|\W{1}])([\w{1}|\W{1}])>";

            while (Regex.IsMatch(mineField, minePattern))
            {
                var mine = Regex.Match(mineField, minePattern);

                char firstCharCode = char.Parse(mine.Groups[1].Value);
                char secondCharCode = char.Parse(mine.Groups[2].Value);

                int bombPower = Math.Abs(firstCharCode - secondCharCode);
                int mineIndex = mineField.IndexOf(mine.Value);

                int blastRadiusStart = mineIndex - bombPower;
                int blastRadiusLenght = bombPower + 4 + bombPower;
                string blastRadius = string.Empty;

                if (blastRadiusStart < 0)
                {
                    var builder = new StringBuilder();
                    builder.Append(mineField.Substring(0, mineIndex));
                    builder.Append(mine);
                    builder.Append(mineField.Substring(mineIndex + 4, bombPower));
                    blastRadius = builder.ToString();
                }
                else if (blastRadiusLenght >= mineField.Length)
                {
                    blastRadiusLenght = mineField.Length - 1;
                    blastRadius = mineField.Substring(blastRadiusStart, blastRadiusLenght);
                }
                else if (blastRadiusStart + blastRadiusLenght >= mineField.Length)
                {
                    blastRadiusLenght = mineField.Length - blastRadiusStart;
                    blastRadius = mineField.Substring(blastRadiusStart, blastRadiusLenght);
                }
                else
                {
                    blastRadius = mineField.Substring(blastRadiusStart, blastRadiusLenght);
                }

                string replace = new string('_', blastRadius.Length);
                mineField = Regex.Replace(mineField, blastRadius, replace);
            }

            Console.WriteLine(mineField);
        }
    }
}