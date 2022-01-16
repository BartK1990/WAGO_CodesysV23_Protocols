using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType
{
    public class Iec608705Object_13M_ME_NC_Client : Iec608705Object_13M_ME_NC, IIec608705ObjectClient_Received
    {
        public Iec608705TypeChannel ObjReceived { get; set; }
    }
}
