using OfficeOpenXml;
using System.Linq;
using WAGO_CodesysV23_Protocols.Model;
using WAGO_CodesysV23_Protocols.Model.Item;
using WAGO_CodesysV23_Protocols.Model.IList;

namespace WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess.Iec608705
{
    public class Iec608705MainConfigurationReadExcelAccess : SheetSpecificDataReadExcelAccess<Iec608705MainConfigurationRowList, Iec608705MainConfigurationRow>
    {
        public Iec608705MainConfigurationReadExcelAccess() : base(Iec608705ExcelWorkbookValidation.MainConfigurationSheetName)
        {
            // Excel sheet columns to read
            columnsNamesToClassDict.Add("Execution Time Default", "ExecutionTimeDefault");
            columnsNamesToClassDict.Add("Execution Time Short", "ExecutionTimeShort");
            columnsNamesToClassDict.Add("Execution Time Long", "ExecutionTimeLong");
        }

        protected override Iec608705MainConfigurationRowList ReadSheetData(ExcelWorksheet worksheet)
        {
            var iec608705104AllObjectAttributesList = new Iec608705MainConfigurationRowList();
            var sheetDataList = iec608705104AllObjectAttributesList.SourceDataList;

            ReadSheetSpecificData(worksheet, sheetDataList);
            return iec608705104AllObjectAttributesList;
        }

        protected override Iec608705MainConfigurationRow GetItem()
        {
            return new Iec608705MainConfigurationRow();
        }

        protected override int RequiredColumnNumber()
        {
            return _columnsNumbersToStructDict.FirstOrDefault(v => v.Value == "ExecutionTimeDefault").Key;
        }
    }
}
