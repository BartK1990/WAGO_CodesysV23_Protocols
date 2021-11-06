using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType
{
    public interface IIec608705Object
    {
        string ConnectionName { get; set; }
        string Comment { get; set; }
        string Address { get; set; }
        Iec608705TypeChannel MainVariable { get; set; }
    }
}