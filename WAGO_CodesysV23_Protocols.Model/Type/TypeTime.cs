namespace WAGO_CodesysV23_Protocols.Model.Type
{
    public class TypeTime
    {
        public int TimeValue
        {
            get { return TimeValue; }
            set
            {
                if (value >= 0)
                {
                    TimeValue = value;
                }
            }
        }

        public string TimeBase
        {
            get { return TimeBase; }
            set 
            {            
                if (TimeBaseType.TypesDict.ContainsValue(value))
                {
                    TimeBase = value;
                }
            } 
        }

        public TypeTime()
        {
            TimeBase = TimeBaseType.TypesDict[TimeBaseTypes.Milisecond.ToString()];
        }

        public override string ToString()
        {
            return $"t#{this.TimeValue.ToString()}{this.TimeBase}";
        }
    }
}
