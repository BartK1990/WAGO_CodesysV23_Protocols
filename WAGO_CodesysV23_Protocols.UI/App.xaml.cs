using System.Windows;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess;
using WAGO_CodesysV23_Protocols.DataAccess.ExcelAccess.Iec608705;
using WAGO_CodesysV23_Protocols.Model;
using WAGO_CodesysV23_Protocols.UI.Data.Repository;
using WAGO_CodesysV23_Protocols.UI.Data.Service;
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
        internal IExcelSheetNameRepository ExcelSheetNameRepository;
        internal IIec608705ObjectsReadRepository Iec608705ObjectsReadRepository;
        internal IIec608705ConnectionsReadRepository Iec608705ConnectionsReadRepository;
        internal IIec608705MainConfigurationReadRepository Iec608705MainConfigurationReadRepository;
        internal IIec608705104ExcelWorkbookValidationService Iec608705104ExcelWorkbookValidationService;
        internal IIec608705ConverterService Iec608705ConverterService;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Application objects initialization
            FileDialog = new ExcelXmlFileDialog();
            ErrorHandler = new ErrorHandler();
            ExcelSheetNameRepository = new ExcelSheetNameRepository(new SheetNamesReadExcelAccess());
            Iec608705ObjectsReadRepository = new Iec608705ObjectsReadRepository(new Iec608705ObjectsReadExcelAccess());
            Iec608705ConnectionsReadRepository = new Iec608705ConnectionsReadRepository(new Iec608705ConnectionsReadExcelAccess());
            Iec608705MainConfigurationReadRepository = new Iec608705MainConfigurationReadRepository(new Iec608705MainConfigurationReadExcelAccess());
            Iec608705104ExcelWorkbookValidationService = new Iec608705104ExcelWorkbookValidationService(new Iec608705ExcelWorkbookValidation());
            Iec608705ConverterService = new Iec608705ConverterService(new Iec608705Converter());
        }
    }
}
