using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType;
using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type;

namespace WAGO_CodesysV23_Protocols.Model.Item
{
    public class Iec608705AllObjectAttributes : IIec608705Object, IIec608705Object_CP56Time, IIec608705Object_Execute, IIec608705Object_13M_ME_NC
    {
        public string ObjectType { get; set; }
        public string ConnectionName { get; set; }
        public string Comment { get; set; }
        public string Address { get; set; }
        public Iec608705TypeChannel MainVariable { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel CP56Time { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel Execute { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel OV { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel BL { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel SB { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel NT { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel IV { get; set; } = new Iec608705TypeChannel();
    }
}
