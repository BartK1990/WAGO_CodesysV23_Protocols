using System.Collections.Generic;

namespace WAGO_CodesysV23_Protocols.Model.Type
{
    public static class TimeBaseType
    {
        public static readonly Dictionary<string, string> TypesDict = new Dictionary<string, string>
            {
                { TimeBaseTypes.Milisecond.ToString(), "ms" },
                { TimeBaseTypes.Second.ToString(), "s" },
                { TimeBaseTypes.Minute.ToString(), "m" },
                { TimeBaseTypes.Hour.ToString(), "h" },
                { TimeBaseTypes.Day.ToString(), "d" }
            };
    }

    public enum TimeBaseTypes
    {
        Milisecond,
        Second,
        Minute,
        Hour,
        Day
    }
}
