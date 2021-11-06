using System;

namespace WAGO_CodesysV23_Protocols.UI.Event
{
    public delegate void NewErrorEventHandler(Object sender, NewErrorEventArgs e);

    public class NewErrorEventArgs : EventArgs
    {
        public string errorMessage { get; set; }
    }
}
