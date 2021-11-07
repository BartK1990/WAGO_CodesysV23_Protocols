using System;

namespace WAGO_CodesysV23_Protocols.Model.Iec608705ObjType.Type
{
    public class Iec608705TypeChannel : IEquatable<Iec608705TypeChannel>
    {
        public string Assignment { get; set; }
        public bool Autoapply { get; set; }

        public Iec608705TypeChannel()
        {
            Autoapply = true;
        }

        public bool Equals(Iec608705TypeChannel other)
        {
            if (other == null)
                return false;
            if (this.Assignment == other.Assignment
                && this.Autoapply == other.Autoapply
                )
                return true;
            return false;
        }
    }
}
