using OfficeOpenXml;
using System.Linq;
using WAGO_CodesysV23_Protocols.Model;
using WAGO_CodesysV23_Protocols.Model.Item;
using WAGO_CodesysV23_Protocols.Model.ItemList;

namespace WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess
{
    public class ProtocolConfigurationConnectionsReadExcelAccess : SheetSpecificDataReadExcelAccess<Iec608705ConnectionsList, Iec608705Connections>
    {
        public ProtocolConfigurationConnectionsReadExcelAccess() : base(Iec608705104ExcelWorkbookValidation.ConnectionsSheetName)
        {
            // Excel sheet columns to read
            columnsNamesToClassDict.Add("ExecutionTimeDefault", "ExecutionTimeDefault");
            columnsNamesToClassDict.Add("ExecutionTimeShort", "ExecutionTimeShort");
            columnsNamesToClassDict.Add("IpAddress", "IP address");
            columnsNamesToClassDict.Add("TcpPort", "ExecutionTimeLong");
        }

        protected override Iec608705ConnectionsList ReadSheetData(ExcelWorksheet worksheet)
        {
            var iec608705104AllObjectAttributesList = new Iec608705ConnectionsList();
            var sheetDataList = iec608705104AllObjectAttributesList.SourceDataList;

            ReadSheetSpecificData(worksheet, sheetDataList);
            return iec608705104AllObjectAttributesList;
        }

        protected override Iec608705Connections GetItem()
        {
            return new Iec608705Connections();
        }

        protected override int RequiredColumnNumber()
        {
            return _columnsNumbersToStructDict.FirstOrDefault(v => v.Value == "ExecutionTimeDefault").Key;
        }
    }
}
