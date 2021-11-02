namespace WAGO_CodesysV23_CommProtocolConfigGenerator.Model.Iec608705104ObjType
{
    public abstract class Iec608705104Object : IIec608705104Object
    {
        public readonly Iec608705104ObjectType ObjectType;
        public string ConnectionName { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public Iec608705104Channel MainVariable { get; set; }

        public Iec608705104Object(Iec608705104ObjectType objectType)
        {
            this.ObjectType = objectType;
        }
    }
}
