namespace WAGO_CodesysV23_Protocols.Model.Type
{
    public class WagoTime
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
                if (WagoTimeBaseType.TypesDict.ContainsValue(value))
                {
                    TimeBase = value;
                }
            } 
        }

        public WagoTime()
        {
            TimeBase = WagoTimeBaseType.TypesDict[WagoTimeBaseTypes.Milisecond.ToString()];
        }

        public override string ToString()
        {
            return $"t#{this.TimeValue.ToString()}{this.TimeBase}";
        }
    }
}
