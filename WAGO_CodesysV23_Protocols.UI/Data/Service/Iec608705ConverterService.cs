using WAGO_CodesysV23_Protocols.Model;

namespace WAGO_CodesysV23_Protocols.UI.Data.Service
{
    internal class Iec608705ConverterService : IIec608705ConverterService
    {
        private readonly Iec608705Converter _iec608705Converter;

        public Iec608705ConverterService(Iec608705Converter iec608705Converter)
        {
            this._iec608705Converter = iec608705Converter;
        }
    }
}
