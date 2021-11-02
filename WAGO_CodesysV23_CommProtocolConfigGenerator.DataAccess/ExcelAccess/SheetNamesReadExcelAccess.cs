using OfficeOpenXml;
using WAGO_CodesysV23_CommProtocolConfigGenerator.Model.ItemList;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.DataAccess.ExcelAccess
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
