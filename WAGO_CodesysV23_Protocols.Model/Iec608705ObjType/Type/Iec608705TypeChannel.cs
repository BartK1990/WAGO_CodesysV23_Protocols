namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type
{
    public class Iec608705TypeChannel
    {
        public string Assignment { get; set; }
        public bool Autoapply { get; set; }

        public Iec608705TypeChannel()
        {
            Autoapply = true;
        }
    }
}
