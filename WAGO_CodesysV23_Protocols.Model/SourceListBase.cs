using System.Collections.Generic;

namespace WAGO_CodesysV23_Protocols.Model
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