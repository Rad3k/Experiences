using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramSQL
{
    class ConvertToExcel
    {
        public void ExportToExcel()
        {
            // Load Excel application
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            // Create empty workbook
            excel.Visible = true;
            object misval=System.Reflection.Missing.Value;
            excel.Workbooks.Open(Definitions.predloha, misval, misval, misval, misval, misval, misval, misval, misval, misval, misval, misval, misval, misval, misval);

            // Create Worksheet from active sheet     
            Microsoft.Office.Interop.Excel._Worksheet workSheet = excel.ActiveSheet;

            // I created Application and Worksheet objects before try/catch,     
            // so that i can close them in finnaly block.     
            // It's IMPORTANT to release these COM objects!!     
            try
            {
                // ------------------------------------------------         
                // Creation of header cells         
                // ------------------------------------------------
                while (true)
                {
                    foreach (string a in Definitions.PCName)
                        workSheet.Cells[5, "B"] = a;
                    foreach (string b in Definitions.Monitor)
                        workSheet.Cells[7, "B"] = b;
                    foreach (string c in Definitions.Ram)
                        workSheet.Cells[8, "B"] = c;
                    foreach (string d in Definitions.CPU)
                        workSheet.Cells[9, "B"] = d;
                    foreach (string e in Definitions.GPU)
                        workSheet.Cells[10, "B"] = e;
                    foreach (string f in Definitions.Motherboard)
                        workSheet.Cells[11, "B"] = f;
                    foreach (string g in Definitions.HDD)
                        workSheet.Cells[12, "B"] = g;
                    foreach (string h in Definitions.OS)
                        workSheet.Cells[21, "B"] = h;
                    foreach (string j in Definitions.Keyboard)
                        workSheet.Cells[13, "B"] = j;
                    foreach (string k in Definitions.Mouse)
                        workSheet.Cells[14, "B"] = k;

                    break;
                }
            }
            finally
            {
            }
        }
    }
}
