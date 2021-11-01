namespace WAGO_CodesysV23_CommProtocolConfigGenerator.Model.Iec608705104Obj
{
    public abstract class Iec608705104Object
    {
        public string ConnectionName;
        protected readonly Iec608705104ObjectType ObjectType;
        public string Address;
        public string Comment;
        public string MainVariable;

        public Iec608705104Object(Iec608705104ObjectType objectType)
        {
            this.ObjectType = objectType;
        }
    }
}
