using System.Collections.Generic;
using WAGO_CodesysV23_CommProtocolConfigGenerator.Model.Iec608705104Obj;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.Model
{
    public class Iec608705104ObjectList : SourceListBase<Iec608705104Object>
    {
        public Iec608705104ObjectList()
        {
            SourceDataList = new List<Iec608705104Object>();
        }
    }
}
