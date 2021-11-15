using System.Collections.Generic;
using System.Threading.Tasks;

namespace WAGO_CodesysV23_Protocols.Model
{
    public class Iec608705ExcelWorkbookValidation
    {
        public const string MainConfigurationSheetName = "Main Configuration";
        public const string ConnectionsSheetName = "Connections";
        public const string ObjectsSheetName = "Objects";

        public bool CheckIfContainsValidSheets(IList<string> sheetCollection)
        {
            if (sheetCollection is null)
                return false;
            if (sheetCollection.Contains(MainConfigurationSheetName) &&
                sheetCollection.Contains(ConnectionsSheetName) &&
                sheetCollection.Contains(ObjectsSheetName)
                )
            {
                return true;
            }
            return false;
        }
        public async Task<bool> CheckIfContainsValidSheetsAsync(IList<string> sheetCollection)
        {
            return await Task.Run(() => CheckIfContainsValidSheets(sheetCollection));
        }
    }
}
