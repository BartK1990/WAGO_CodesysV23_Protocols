using OfficeOpenXml;
using System.IO;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.DataAccess.ExcelAccess
{
    public abstract class ExcelAccess<T>
    {
        protected ExcelPackage GetExcelPackage(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            return new ExcelPackage(fileInfo);
        }
    }
}
