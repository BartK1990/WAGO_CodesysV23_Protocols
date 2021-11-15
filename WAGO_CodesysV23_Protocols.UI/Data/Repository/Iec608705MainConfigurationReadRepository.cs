using System.Threading.Tasks;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess.Iec608705;
using WAGO_CodesysV23_Protocols.Model.IList;

namespace WAGO_CodesysV23_Protocols.UI.Data.Repository
{
    internal class Iec608705MainConfigurationReadRepository : ExcelRepository<Iec608705MainConfigurationList, Iec608705MainConfigurationReadExcelAccess>, IIec608705MainConfigurationReadRepository
    {
        public Iec608705MainConfigurationReadRepository(Iec608705MainConfigurationReadExcelAccess excelAccess) : base(excelAccess)
        {
        }

        public async Task<Iec608705MainConfigurationList> ReadDataAsync(string path)
        {
            return await ExcelAccess.ReadExcelDataAsync(path);
        }
    }
}
