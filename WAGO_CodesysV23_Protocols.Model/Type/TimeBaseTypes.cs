using System.Collections.Generic;

namespace WAGO_CodesysV23_Protocols.Model.Type
{
    public static class TimeBaseTypes
    {
        public static readonly Dictionary<string, string> TypesDict = new Dictionary<string, string>
            {
                { "Milisecond", "ms" },
                { "Second", "s" },
                { "Minute", "m" },
                { "Hour", "h" },
                { "Day", "d" }
            };
    }
}
