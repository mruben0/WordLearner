using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace WordLearner
{
   public class DictManager
    {
        
        public string Path { get; set; }
        public static int i { get; set; }
        public static string a { get; set; }
        public static string b { get; set; }
        public static string c { get; set; }
        public static string d { get; set; }

        public DictManager (string path)
        {
            Path = path;
        }

        WordList WL = new WordList(i, a, b, c, d);

       
        public List<WordList> wordList = new List<WordList>();

        public List<WordList> addWord(int a, string b, string c, string d, string e)
        {


            wordList.Add(new WordList(a, b, c, d, e));
            return wordList;
        }

        public void FindFromExcel()
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();

            //excelApp.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = excelApp.Workbooks.Open(Path);

            //Excel.Workbook excelworkbook = excelApp.Workbooks.Add(@"C:\Users\mrube\Desktop\D\D.xlsx");
            // Excel.Worksheet WSheet = excelworkbook.ActiveSheet;

            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            // excelApp.Cells[1, 2] = "test";
            // Console.WriteLine(xlRange.Cells[4,2].Value2.ToString());

            for (int i = 2; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, 2] != null && xlRange.Cells[i, 2].Value2 != null && xlRange.Cells[i, 4] != null && xlRange.Cells[i, 4].Value2 != null)
                {
                    // Console.WriteLine(xlRange.Cells[i, 4].Value2.ToString());
                    if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null && xlRange.Cells[i, 3] != null && xlRange.Cells[i, 3].Value2 != null)
                        addWord(i, xlRange.Cells[i,1 ].Value2.ToString(), xlRange.Cells[i, 2].Value2.ToString(), xlRange.Cells[i, 3].Value2.ToString(), xlRange.Cells[i, 4].Value2.ToString());
                    else addWord(i, "-", xlRange.Cells[i, 2].Value2.ToString(),"-", xlRange.Cells[i, 4].Value2.ToString());

                    //Console.WriteLine(excelApp.Cells[1,1].Value2.ToString());

                }



            }


            GC.Collect();
            GC.WaitForPendingFinalizers();
            xlWorkbook.Close(0);
            excelApp.Quit();
            

        }
    }
}
