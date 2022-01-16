using System.Collections.Generic;
using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705Connection
{
    public interface IIec608705Objects
    {
        IList<Iec608705Object> Objects { get; set; }
    }
}
