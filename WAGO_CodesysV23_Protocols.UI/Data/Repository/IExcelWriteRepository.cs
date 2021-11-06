using System.Threading.Tasks;

namespace WAGO_CodesysV23_Protocols.UI.Data.Repository
{
    internal interface IExcelWriteRepository<TData>
    {
        Task WriteDataAsync(string path, TData data);
    }
}