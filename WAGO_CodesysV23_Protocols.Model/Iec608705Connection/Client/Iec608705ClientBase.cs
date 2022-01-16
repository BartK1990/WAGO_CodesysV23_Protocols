using System.Collections.Generic;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705Connection.Client
{
    public abstract class Iec608705ClientBase<T> : Iec608705ServerClientBase
    {
        public IList<T> Connections { get; set; }
    }
}
