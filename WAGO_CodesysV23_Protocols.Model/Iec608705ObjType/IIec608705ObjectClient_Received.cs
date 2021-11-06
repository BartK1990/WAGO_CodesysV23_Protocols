using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType
{
    internal interface IIec608705ObjectClient_Received : IIec608705ObjectClient
    {
        Iec608705TypeChannel ObjReceived { get; set; }
    }
}
