using OfficeOpenXml;
using WAGO_CodesysV23_Protocols.Model.IList;

namespace WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess
{
    public class SheetNamesReadExcelAccess : ExcelAccessRead<ExcelSheetName>
    {
        protected override ExcelSheetName GetExcelData(ExcelPackage package)
        {
            ExcelSheetName excelSheetName = new ExcelSheetName();
            foreach (var worksheet in package.Workbook.Worksheets)
            {
                excelSheetName.SheetCollection.Add(worksheet.Name);
            }
            return excelSheetName;
        }
    }
}
