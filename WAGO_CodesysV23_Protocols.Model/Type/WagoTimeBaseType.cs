using System.Collections.Generic;

namespace WAGO_CodesysV23_Protocols.Model.Type
{
    public enum WagoTimeBaseTypes
    {
        Milisecond,
        Second,
        Minute,
        Hour,
        Day
    }

    public static class WagoTimeBaseType
    {
        public static readonly Dictionary<string, string> TypesDict = new Dictionary<string, string>
            {
                { WagoTimeBaseTypes.Milisecond.ToString(), "ms" },
                { WagoTimeBaseTypes.Second.ToString(), "s" },
                { WagoTimeBaseTypes.Minute.ToString(), "m" },
                { WagoTimeBaseTypes.Hour.ToString(), "h" },
                { WagoTimeBaseTypes.Day.ToString(), "d" }
            };
    }
}
