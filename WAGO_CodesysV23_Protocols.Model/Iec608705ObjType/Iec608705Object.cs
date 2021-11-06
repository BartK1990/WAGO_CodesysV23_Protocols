using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType
{
    public abstract class Iec608705Object : IIec608705Object
    {
        public readonly Iec608705ObjectTypes ObjectType;
        public string ConnectionName { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public Iec608705TypeChannel MainVariable { get; set; }

        public Iec608705Object(Iec608705ObjectTypes objectType)
        {
            this.ObjectType = objectType;
        }
    }
}
