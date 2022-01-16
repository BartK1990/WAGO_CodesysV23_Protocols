using System.Collections.Generic;
using WAGO_CodesysV23_Protocols.Model.Iec608705Connection;
using WAGO_CodesysV23_Protocols.Model.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705Configuration
{
    public interface IIec60870Configuration
    {
        WagoTime ExecutionTimeDefault { get; set; }
        WagoTime ExecutionTimeShort { get; set; }
        WagoTime ExecutionTimeLong { get; set; }

        IList<IIec608705ServerClientBase> ServerClientList { get; set; }
    }
}
