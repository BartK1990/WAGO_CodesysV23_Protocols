using System;
using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType;
using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type;

namespace WAGO_CodesysV23_Protocols.Model.Item
{
    public class Iec608705AllObjectRow : IEquatable<Iec608705AllObjectRow>, IIec608705Object, IIec608705Object_CP56Time, IIec608705Object_Execute, IIec608705Object_13M_ME_NC
    {
        public string ObjectType { get; set; }
        public string ConnectionName { get; set; }
        public string Comment { get; set; }
        public string Address { get; set; }
        public Iec608705TypeChannel MainVariable { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel CP56Time { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel Execute { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel OV { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel BL { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel SB { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel NT { get; set; } = new Iec608705TypeChannel();
        public Iec608705TypeChannel IV { get; set; } = new Iec608705TypeChannel();

        public bool Equals(Iec608705AllObjectRow other)
        {
            if (other == null)
                return false;
            if (this.ObjectType == other.ObjectType
                && this.ConnectionName == other.ConnectionName
                && this.Comment == other.Comment
                && this.Address == other.Address
                && this.MainVariable.Equals(other.MainVariable)
                && this.CP56Time.Equals(other.CP56Time)
                && this.Execute.Equals(other.Execute)
                && this.OV.Equals(other.OV)
                && this.BL.Equals(other.BL)
                && this.SB.Equals(other.SB)
                && this.NT.Equals(other.NT)
                && this.IV.Equals(other.IV)
                )
                return true;
            return false;
        }
    }
}
