using System.Collections.Generic;
using WAGO_CodesysV23_Protocols.Model.Iec608705Connection;
using WAGO_CodesysV23_Protocols.Model.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705Configuration
{
    public class Iec60870Configuration : IIec60870Configuration
    {
        public WagoTime ExecutionTimeDefault { get; set; } = new WagoTime();
        public WagoTime ExecutionTimeShort { get; set; } = new WagoTime();
        public WagoTime ExecutionTimeLong { get; set; } = new WagoTime();

        public IList<IIec608705ServerClientBase> ServerClientList { get; set; }
    }
}
