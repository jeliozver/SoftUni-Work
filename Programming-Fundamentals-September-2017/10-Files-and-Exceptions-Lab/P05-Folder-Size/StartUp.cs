namespace P05_Folder_Size
{
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            Directory.CreateDirectory("TestFolder");

            string[] files = Directory.GetFiles("TestFolder");

            long totalSize = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                totalSize += fileInfo.Length;
            }

            string result = $"{totalSize / 1024.0 / 1024.0}";

            File.WriteAllText("Output.txt", result);
        }
    }
}