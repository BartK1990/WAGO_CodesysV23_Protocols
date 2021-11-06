using System.Windows;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess;
using WAGO_CodesysV23_Protocols.UI.Data.Repository;
using WAGO_CodesysV23_Protocols.UI.View.Services;
using WAGO_CodesysV23_Protocols.UI.ViewModel.Service;

namespace WAGO_CodesysV23_Protocols.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal IExcelXmlFileDialog FileDialog;
        internal IErrorHandler ErrorHandler;
        internal IProtocolConfigurationObjectsReadRepository ProtocolConfigurationObjectsReadRepository;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Application objects initialization
            FileDialog = new ExcelXmlFileDialog();
            ErrorHandler = new ErrorHandler();
            ProtocolConfigurationObjectsReadRepository = new ProtocolConfigurationObjectsReadRepository(new ProtocolConfigurationObjectsReadExcelAccess());
        }
    }
}
