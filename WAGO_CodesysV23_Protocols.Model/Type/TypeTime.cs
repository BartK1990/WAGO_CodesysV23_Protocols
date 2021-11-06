namespace WAGO_CodesysV23_Protocols.Model.Type
{
    public class TypeTime
    {
        public int TimeValue { get; set; }
        public string TimeBase
        {
            get { return TimeBase; }
            set 
            {            
                if (TimeBaseTypes.TypesDict.ContainsValue(value))
                {
                    TimeBase = value;
                }
            } 
        }

        public TypeTime()
        {
            TimeBase = TimeBaseTypes.TypesDict["Milisecond"];
        }
    }
}
