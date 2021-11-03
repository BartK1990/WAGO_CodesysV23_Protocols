using System.Threading.Tasks;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.Data.Repository
{
    internal interface IExcelReadRepository<TData>
    {
        Task<TData> ReadDataAsync(string path);
    }
}