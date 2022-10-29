using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Tiff2Excel
{
    class XLSHelper
    {
        Microsoft.Office.Interop.Excel.Application excel;
        Microsoft.Office.Interop.Excel.Workbook worKbooK;
        Microsoft.Office.Interop.Excel.Worksheet worksheet;
        Microsoft.Office.Interop.Excel.Range celLrangE;

        internal XLSHelper()
        {
            excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = false;
            excel.DisplayAlerts = false;

            worKbooK = excel.Workbooks.Add(Type.Missing);
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet; worksheet.Name = "Tiff2Excel";
        }
        internal void saveFileAndQuit(string filename)
        {
            worKbooK.SaveAs(filename);
            worKbooK.Close();
            excel.Quit();
        }
        internal void writeVector(ushort[] values, int column)
        {
            for (int i = 0; i < values.Length; i++)
            {
                worksheet.Cells[i+1, column+1] = values[i];
            }
        }



    }
}
