using System.Threading.Tasks;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess.Iec608705;
using WAGO_CodesysV23_Protocols.Model.ItemList;

namespace WAGO_CodesysV23_Protocols.UI.Data.Repository
{
    internal class ProtocolConfigurationObjectsReadRepository : ExcelRepository<Iec608705AllObjectAttributesList, Iec608705ObjectsReadExcelAccess>, IProtocolConfigurationObjectsReadRepository
    {
        public ProtocolConfigurationObjectsReadRepository(Iec608705ObjectsReadExcelAccess excelAccess) : base(excelAccess)
        {
        }

        public async Task<Iec608705AllObjectAttributesList> ReadDataAsync(string path)
        {
            return await ExcelAccess.ReadExcelDataAsync(path);
        }
    }
}
