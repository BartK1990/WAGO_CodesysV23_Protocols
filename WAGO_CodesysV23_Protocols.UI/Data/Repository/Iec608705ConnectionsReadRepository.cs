using System.Threading.Tasks;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess.Iec608705;
using WAGO_CodesysV23_Protocols.Model.IList;

namespace WAGO_CodesysV23_Protocols.UI.Data.Repository
{
    internal class Iec608705ConnectionsReadRepository : ExcelRepository<Iec608705ConnectionsList, Iec608705ConnectionsReadExcelAccess>, IIec608705ConnectionsReadRepository
    {
        public Iec608705ConnectionsReadRepository(Iec608705ConnectionsReadExcelAccess excelAccess) : base(excelAccess)
        {
        }

        public async Task<Iec608705ConnectionsList> ReadDataAsync(string path)
        {
            return await ExcelAccess.ReadExcelDataAsync(path);
        }
    }
}
