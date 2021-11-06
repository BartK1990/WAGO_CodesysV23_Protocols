namespace WAGO_CodesysV23_Protocols.Model.Iec608705104ObjType
{
    public interface IIec608705104Object
    {
        string ConnectionName { get; set; }
        string Comment { get; set; }
        string Address { get; set; }
        Iec608705104Channel MainVariable { get; set; }
    }
}