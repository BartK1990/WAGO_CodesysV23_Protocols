using WAGO_CodesysV23_Protocols.Model.Type;

namespace WAGO_CodesysV23_Protocols.Model.Item
{
    public class Iec608705MainConfiguration
    {
        public TypeTime ExecutionTimeDefault { get; set; } = new TypeTime();
        public TypeTime ExecutionTimeShort { get; set; } = new TypeTime();
        public TypeTime ExecutionTimeLong { get; set; } = new TypeTime();
    }
}
