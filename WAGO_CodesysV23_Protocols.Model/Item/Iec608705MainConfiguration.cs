using WAGO_CodesysV23_Protocols.Model.Type;

namespace WAGO_CodesysV23_Protocols.Model.Item
{
    public class Iec608705MainConfiguration
    {
        public WagoTime ExecutionTimeDefault { get; set; } = new WagoTime();
        public WagoTime ExecutionTimeShort { get; set; } = new WagoTime();
        public WagoTime ExecutionTimeLong { get; set; } = new WagoTime();
    }
}
