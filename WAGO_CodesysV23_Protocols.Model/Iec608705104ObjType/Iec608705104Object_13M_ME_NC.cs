namespace WAGO_CodesysV23_Protocols.Model.Iec608705104ObjType
{
    public class Iec608705104Object_13M_ME_NC : Iec608705104Object, IIec608705104Object_13M_ME_NC
    {
        public Iec608705104Channel OV { get; set; }
        public Iec608705104Channel BL { get; set; }
        public Iec608705104Channel SB { get; set; }
        public Iec608705104Channel NT { get; set; }
        public Iec608705104Channel IV { get; set; }

        public Iec608705104Object_13M_ME_NC() : base(Iec608705104ObjectType.Obj13M_ME_NC)
        {
        }
    }
}
