using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType
{
    internal class Iec608705Object_13M_ME_NC : Iec608705Object, IIec608705Object_13M_ME_NC
    {
        public Iec608705TypeChannel OV { get; set; }
        public Iec608705TypeChannel BL { get; set; }
        public Iec608705TypeChannel SB { get; set; }
        public Iec608705TypeChannel NT { get; set; }
        public Iec608705TypeChannel IV { get; set; }

        public Iec608705Object_13M_ME_NC() : base(Iec608705ObjectTypes.Obj13M_ME_NC)
        {
        }
    }
}
