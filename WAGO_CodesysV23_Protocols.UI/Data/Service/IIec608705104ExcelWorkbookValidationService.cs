using System.Collections.Generic;
using System.Threading.Tasks;

namespace WAGO_CodesysV23_Protocols.UI.Data.Service
{
    internal interface IIec608705104ExcelWorkbookValidationService
    {
        Task<bool> CheckIfContainsValidSheetsAsync(IList<string> sheetCollection);
    }
}
