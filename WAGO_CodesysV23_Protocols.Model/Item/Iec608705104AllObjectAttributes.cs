﻿using WAGO_CodesysV23_Protocols.Model.Iec608705104ObjType;

namespace WAGO_CodesysV23_Protocols.Model.Item
{
    public class Iec608705104AllObjectAttributes : IIec608705104Object, IIec608705104Object_CP56Time, IIec608705104Object_Execute, IIec608705104Object_13M_ME_NC
    {
        public string ObjectType { get; set; }
        public string ConnectionName { get; set; }
        public string Comment { get; set; }
        public string Address { get; set; }
        public Iec608705104Channel MainVariable { get; set; }
        public Iec608705104Channel CP56Time { get; set; }
        public Iec608705104Channel Execute { get; set; }
        public Iec608705104Channel OV { get; set; }
        public Iec608705104Channel BL { get; set; }
        public Iec608705104Channel SB { get; set; }
        public Iec608705104Channel NT { get; set; }
        public Iec608705104Channel IV { get; set; }

        public Iec608705104AllObjectAttributes()
        {
            MainVariable = new Iec608705104Channel();
            CP56Time = new Iec608705104Channel();
            Execute = new Iec608705104Channel();
            OV = new Iec608705104Channel();
            BL = new Iec608705104Channel();
            SB = new Iec608705104Channel();
            NT = new Iec608705104Channel();
            IV = new Iec608705104Channel();
        }
    }
}