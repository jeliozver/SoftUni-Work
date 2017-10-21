namespace P06_EXCELlent_Knowledge
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using Excel = Microsoft.Office.Interop.Excel;

    public class StartUp
    {
        public static void Main()
        {
            var path = Path.GetFullPath(@"Input.xlsx");

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            var result = new List<string>();

            for (int i = 1; i <= rowCount; i++)
            {
                string currentLine = string.Empty;

                for (int j = 1; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        currentLine += $"{xlRange.Cells[i, j].Value2.ToString()}|";
                    }
                }

                result.Add(currentLine);
            }

            result = result
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Distinct()
                .ToList();

            File.WriteAllLines("Output.txt", result);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}