using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.View.Services;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.ViewModel.Service;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IExcelXmlFileDialog FileDialog;
        public IErrorHandler ErrorHandler;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Application objects initialization
            FileDialog = new ExcelXmlFileDialog();
            ErrorHandler = new ErrorHandler();
        }
    }
}
