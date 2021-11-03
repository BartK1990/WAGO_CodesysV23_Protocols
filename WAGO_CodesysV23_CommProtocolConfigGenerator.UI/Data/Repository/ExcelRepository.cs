using WAGO_CodesysV23_CommProtocolConfigGenerator.DataAccess.ExcelAccess;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.Data.Repository
{
    internal abstract class ExcelRepository<TData, TExcelAccess> : IExcelRepository
        where TData : class
        where TExcelAccess : ExcelAccess<TData>
    {
        protected readonly TExcelAccess ExcelAccess;

        public ExcelRepository(TExcelAccess excelAccess)
        {
            this.ExcelAccess = excelAccess;
        }
    }
}
