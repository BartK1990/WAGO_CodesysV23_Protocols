using System.Threading.Tasks;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess;
using WAGO_CodesysV23_Protocols.Model.ItemList;

namespace WAGO_CodesysV23_Protocols.UI.Data.Repository
{
    internal class ProtocolConfigurationObjectsReadRepository : ExcelRepository<Iec608705AllObjectAttributesList, ProtocolConfigurationObjectsReadExcelAccess>, IProtocolConfigurationObjectsReadRepository
    {
        public ProtocolConfigurationObjectsReadRepository(ProtocolConfigurationObjectsReadExcelAccess excelAccess) : base(excelAccess)
        {
        }

        public async Task<Iec608705AllObjectAttributesList> ReadDataAsync(string path)
        {
            return await ExcelAccess.ReadExcelDataAsync(path);
        }
    }
}
