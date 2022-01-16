using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType
{
    public interface IIec608705Object_13M_ME_NC
    {
        Iec608705TypeChannel OV { get; set; }
        Iec608705TypeChannel BL { get; set; }
        Iec608705TypeChannel SB { get; set; }
        Iec608705TypeChannel NT { get; set; }
        Iec608705TypeChannel IV { get; set; }
    }
}
