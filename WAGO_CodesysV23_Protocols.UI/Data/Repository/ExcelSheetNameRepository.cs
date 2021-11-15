using System.Threading.Tasks;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess;
using WAGO_CodesysV23_Protocols.Model.IList;

namespace WAGO_CodesysV23_Protocols.UI.Data.Repository
{
    internal class ExcelSheetNameRepository : ExcelRepository<ExcelSheetName, SheetNamesReadExcelAccess>, IExcelSheetNameRepository
    {
        public ExcelSheetNameRepository(SheetNamesReadExcelAccess excelAccess) : base(excelAccess)
        {
        }

        public async Task<ExcelSheetName> ReadDataAsync(string path)
        {
            return await ExcelAccess.ReadExcelDataAsync(path);
        }
    }
}
