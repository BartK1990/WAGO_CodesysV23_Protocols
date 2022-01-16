using WAGO_CodesysV23_Protocols.Model.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType
{
    public class Iec608705Object_13M_ME_NC_Server : Iec608705Object_13M_ME_NC, IIec608705ObjectServer_TransmissionInterval
    {
        public WagoTime TransmissionInterval { get; set; }
    }
}
