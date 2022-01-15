using System.Threading.Tasks;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess.Iec608705;
using WAGO_CodesysV23_Protocols.Model.IList;

namespace WAGO_CodesysV23_Protocols.UI.Data.Repository
{
    internal class Iec608705ObjectsReadRepository : ExcelRepository<Iec608705AllObjectRowList, Iec608705ObjectsReadExcelAccess>, IIec608705ObjectsReadRepository
    {
        public Iec608705ObjectsReadRepository(Iec608705ObjectsReadExcelAccess excelAccess) : base(excelAccess)
        {
        }

        public async Task<Iec608705AllObjectRowList> ReadDataAsync(string path)
        {
            return await ExcelAccess.ReadExcelDataAsync(path);
        }
    }
}
