using System.Collections.Generic;
using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705Connection.Client.Connection
{
    public abstract class Iec608705ConnectionBase : IIec608705Objects
    {
        public IList<Iec608705Object> Objects { get; set; }
    }
}
