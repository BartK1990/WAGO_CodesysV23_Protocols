using OfficeOpenXml;
using System.Linq;
using WAGO_CodesysV23_Protocols.Model;
using WAGO_CodesysV23_Protocols.Model.Item;
using WAGO_CodesysV23_Protocols.Model.ItemList;

namespace WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess
{
    public class ProtocolConfigurationMainConfigurationReadExcelAccess : SheetSpecificDataReadExcelAccess<Iec608705MainConfigurationList, Iec608705MainConfiguration>
    {
        public ProtocolConfigurationMainConfigurationReadExcelAccess() : base(Iec608705104ExcelWorkbookValidation.MainListSheetName)
        {
            // Excel sheet columns to read
            columnsNamesToClassDict.Add("ExecutionTimeDefault", "ExecutionTimeDefault");
            columnsNamesToClassDict.Add("ExecutionTimeShort", "ExecutionTimeShort");
            columnsNamesToClassDict.Add("ExecutionTimeLong", "ExecutionTimeLong");
        }

        protected override Iec608705MainConfigurationList ReadSheetData(ExcelWorksheet worksheet)
        {
            var iec608705104AllObjectAttributesList = new Iec608705MainConfigurationList();
            var sheetDataList = iec608705104AllObjectAttributesList.SourceDataList;

            ReadSheetSpecificData(worksheet, sheetDataList);
            return iec608705104AllObjectAttributesList;
        }

        protected override Iec608705MainConfiguration GetItem()
        {
            return new Iec608705MainConfiguration();
        }

        protected override int RequiredColumnNumber()
        {
            return _columnsNumbersToStructDict.FirstOrDefault(v => v.Value == "ExecutionTimeDefault").Key;
        }
    }
}
