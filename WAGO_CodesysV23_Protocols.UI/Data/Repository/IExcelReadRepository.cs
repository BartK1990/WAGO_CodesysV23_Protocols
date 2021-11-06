using System.Threading.Tasks;

namespace WAGO_CodesysV23_Protocols.UI.Data.Repository
{
    internal interface IExcelReadRepository<TData>
    {
        Task<TData> ReadDataAsync(string path);
    }
}