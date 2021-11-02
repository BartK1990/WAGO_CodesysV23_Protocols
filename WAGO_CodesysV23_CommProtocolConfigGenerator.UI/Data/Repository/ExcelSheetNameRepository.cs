using System.Threading.Tasks;
using WAGO_CodesysV23_CommProtocolConfigGenerator.DataAccess.ExcelAccess;
using WAGO_CodesysV23_CommProtocolConfigGenerator.Model.ItemList;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.Data.Repositories
{
    public class ExcelSheetNameRepository : ExcelRepository<ExcelSheetName, SheetNamesReadExcelAccess>, IExcelSheetNameRepository
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
