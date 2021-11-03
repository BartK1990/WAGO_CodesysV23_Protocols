using System.Threading.Tasks;
using WAGO_CodesysV23_CommProtocolConfigGenerator.DataAccess.ExcelAccess;
using WAGO_CodesysV23_CommProtocolConfigGenerator.Model.ItemList;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.Data.Repository
{
    internal class ProtocolConfigurationObjectsReadRepository : ExcelRepository<Iec608705104AllObjectAttributesList, ProtocolConfigurationObjectsReadExcelAccess>, IProtocolConfigurationObjectsReadRepository
    {
        public ProtocolConfigurationObjectsReadRepository(ProtocolConfigurationObjectsReadExcelAccess excelAccess) : base(excelAccess)
        {
        }

        public async Task<Iec608705104AllObjectAttributesList> ReadDataAsync(string path)
        {
            return await ExcelAccess.ReadExcelDataAsync(path);
        }
    }
}
