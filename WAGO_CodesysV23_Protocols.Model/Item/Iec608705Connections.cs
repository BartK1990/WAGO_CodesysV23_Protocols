using WAGO_CodesysV23_Protocols.Model.Type;

namespace WAGO_CodesysV23_Protocols.Model.Item
{
    public class Iec608705Connections
    {
        public string Name { get; set; }
        public string Connection { get; set; }
        public string IpAddress { get; set; }
        public string TcpPort { get; set; }
        public string AsduAddress1 { get; set; }
        public string AsduAddress2 { get; set; }
        public string OriginatorAddress { get; set; }
        public WagoTime T0 { get; set; } = new WagoTime();
        public WagoTime T1 { get; set; } = new WagoTime();
        public WagoTime T2 { get; set; } = new WagoTime();
        public WagoTime T3 { get; set; } = new WagoTime();
        public string K { get; set; }
        public string W { get; set; }
    }
}
