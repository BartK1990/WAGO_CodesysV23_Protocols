using System.Threading.Tasks;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.Data.Repositories
{
    public interface IExcelWriteRepository<TData>
    {
        Task WriteDataAsync(string path, TData data);
    }
}