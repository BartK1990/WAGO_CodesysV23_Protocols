using System.Windows;
using WAGO_CodesysV23_CommProtocolConfigGenerator.DataAccess.ExcelAccess;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.Data.Repository;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.View.Services;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.ViewModel.Service;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI
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
