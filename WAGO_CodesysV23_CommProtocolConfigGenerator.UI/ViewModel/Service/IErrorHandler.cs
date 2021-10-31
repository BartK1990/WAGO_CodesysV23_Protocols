using System;
using System.Collections.Generic;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.ViewModel.Service
{
    using Event;

    public interface IErrorHandler
    {
        public event NewErrorEventHandler NewError;
        ICollection<string> ErrorList { get; }

        void HandleError(Exception ex);
    }
}
