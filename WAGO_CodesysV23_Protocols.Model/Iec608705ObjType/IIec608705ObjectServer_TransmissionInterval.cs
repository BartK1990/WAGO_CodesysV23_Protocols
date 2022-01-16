using WAGO_CodesysV23_Protocols.Model.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType
{
    public interface IIec608705ObjectServer_TransmissionInterval : IIec608705ObjectServer
    {
        WagoTime TransmissionInterval { get; set; }
    }
}
