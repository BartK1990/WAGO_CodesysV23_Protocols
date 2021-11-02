using System.Collections.Generic;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.Model
{
    public abstract class SourceListBase<T>
    {
        public IList<T> SourceDataList { get; set; }

        public SourceListBase()
        {
            SourceDataList = new List<T>();
        }
    }
}