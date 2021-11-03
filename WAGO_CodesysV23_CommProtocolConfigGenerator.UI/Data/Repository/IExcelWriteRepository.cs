using System.Threading.Tasks;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.Data.Repository
{
    internal interface IExcelWriteRepository<TData>
    {
        Task WriteDataAsync(string path, TData data);
    }
}