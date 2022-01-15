using System.Collections.Generic;
using WAGO_CodesysV23_Protocols.Model.Iec608705Connection;
using WAGO_CodesysV23_Protocols.Model.Iec608705MainConf;
using WAGO_CodesysV23_Protocols.Model.Iec608705ObjType;

namespace WAGO_CodesysV23_Protocols.Model
{
    public class Iec608705Data
    {
        public IIec60870MainConfiguration Iec60870MainConfiguration { get; set; }

        public List<IIec608705ServerClientBase> Iec608705ServerClientList { get; set; }

        public List<IIec608705Object> Iec608705ObjectList { get; set; }
    }
}
