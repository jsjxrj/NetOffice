﻿using System;
using System.Collections.Generic;
using System.Text;

using Excel = NetOffice.ExcelApi;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 1 million cells in excel.");

            Excel.Application application = new NetOffice.ExcelApi.Application();
            application.DisplayAlerts = false;
            application.Interactive = false;
            application.ScreenUpdating = false;

            application.Workbooks.Add();

            Excel.Worksheet workSheet = (Excel.Worksheet)application.Workbooks[1].Worksheets[1];
            Excel.Range rangeCells = workSheet.Cells;
           
            // row
            int counter = 0;
            DateTime startTime = DateTime.Now;
            for (int i = 1; i <= 10000; i++)
            {
                // column
                for (int y = 1; y <= 100; y++)
                {
                    Excel.Range range = rangeCells[i, y];
                    range.Value = "TestValue";
                    range.Dispose();
                    counter++;
                }
                if (i % 100 == 0)
                    Console.WriteLine("{0} Cells written. Time elapsed: {1}", counter, DateTime.Now - startTime);
           }
           
           // quit and dispose
           application.Quit();
           application.Dispose();

           Console.WriteLine("Done!");
        }
    }
}
