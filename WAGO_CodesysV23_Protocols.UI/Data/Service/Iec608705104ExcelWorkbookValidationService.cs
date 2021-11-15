using System.Collections.Generic;
using System.Threading.Tasks;
using WAGO_CodesysV23_Protocols.Model;

namespace WAGO_CodesysV23_Protocols.UI.Data.Service
{
    internal class Iec608705104ExcelWorkbookValidationService : IIec608705104ExcelWorkbookValidationService
    {
        private readonly Iec608705ExcelWorkbookValidation _iec608705104ExcelWorkbookValidation;

        public Iec608705104ExcelWorkbookValidationService(Iec608705ExcelWorkbookValidation iec608705104ExcelWorkbookValidation)
        {
            this._iec608705104ExcelWorkbookValidation = iec608705104ExcelWorkbookValidation;
        }

        public async Task<bool> CheckIfContainsValidSheetsAsync(IList<string> sheetCollection)
        {
            return await _iec608705104ExcelWorkbookValidation.CheckIfContainsValidSheetsAsync(sheetCollection);
        }
    }
}
