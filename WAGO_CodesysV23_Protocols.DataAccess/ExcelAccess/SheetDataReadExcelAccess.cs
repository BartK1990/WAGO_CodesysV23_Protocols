using OfficeOpenXml;
using System.Linq;
using WAGO_CodesysV23_Protocols.DataAccess.Exceptions;

namespace WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess
{
    public abstract class SheetDataReadExcelAccess<T> : ExcelAccessRead<T>
    {
        protected readonly string SheetName;

        public SheetDataReadExcelAccess(string sheetName)
        {
            this.SheetName = sheetName;
        }

        protected override T GetExcelData(ExcelPackage package)
        {
            if(!package.Workbook.Worksheets.Any(sheet => sheet.Name == SheetName))
            {
                throw new InvalidExcelSheetException($"Worksheet [{SheetName}] does not exists");
            }
            ExcelWorksheet worksheet = package.Workbook.Worksheets[SheetName];
            return ReadSheetData(worksheet);
        }

        protected abstract T ReadSheetData(ExcelWorksheet worksheet);

        protected string GetCellValue(object cell)
        {
            if (cell == null)
                return string.Empty;
            return cell.ToString();
        }

        protected int GetLastSheetRow(ExcelWorksheet worksheet)
        {
            if (worksheet.Dimension == null)
            {
                return 0;
            }
            var row = worksheet.Dimension.Rows;
            while (row >= 1)
            {
                var range = worksheet.Cells[row, 1, row, worksheet.Dimension.Columns];
                if (range.Any(c => !string.IsNullOrEmpty(c.Text)))
                {
                    break;
                }
                row--;
            }
            return row;
        }

        protected int GetLastSheetColumn(ExcelWorksheet worksheet)
        {
            if (worksheet.Dimension == null)
            {
                return 0;
            }
            var column = worksheet.Dimension.Columns;
            while (column >= 1)
            {
                var range = worksheet.Cells[1, column, worksheet.Dimension.Rows, column];
                if (range.Any(c => !string.IsNullOrEmpty(c.Text)))
                {
                    break;
                }
                column--;
            }
            return column;
        }
    }
}
