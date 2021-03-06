using System;

namespace WAGO_CodesysV23_Protocols.DataAccess.Exceptions
{
    public class InvalidExcelSheetException : Exception
    {
        public InvalidExcelSheetException()
        {
        }

        public InvalidExcelSheetException(string message)
            : base(message)
        {
        }

        public InvalidExcelSheetException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
