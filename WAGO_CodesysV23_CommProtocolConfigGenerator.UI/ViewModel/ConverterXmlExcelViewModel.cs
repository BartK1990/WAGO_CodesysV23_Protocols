using System;
using System.Threading.Tasks;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.Event;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.View.Services;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.ViewModel.Command;
using WAGO_CodesysV23_CommProtocolConfigGenerator.UI.ViewModel.Service;

namespace WAGO_CodesysV23_CommProtocolConfigGenerator.UI.ViewModel
{
    public class ConverterXmlExcelViewModel : ViewModelBase
    {
        private readonly IExcelXmlFileDialog _fileDialog;
        private readonly IErrorHandler _errorHandler;

        private string _loggerText;
        public string LoggerText
        {
            get => this._loggerText;
            set { this.SetAndNotify(ref this._loggerText, value, () => this.LoggerText); }
        }

        private bool _protocolConfigurationLoading;
        public bool ProtocolConfigurationLoading
        {
            get => this._protocolConfigurationLoading;
            set { this.SetAndNotify(ref this._protocolConfigurationLoading, value, () => this.ProtocolConfigurationLoading); }
        }

        private string _protocolConfigurationPath;
        public string ProtocolConfigurationPath
        {
            get => this._protocolConfigurationPath;
            set { this.SetAndNotify(ref this._protocolConfigurationPath, value, () => this.ProtocolConfigurationPath); }
        }

        public ConverterXmlExcelViewModel(IExcelXmlFileDialog fileDialog, 
            IErrorHandler errorHandler)
        {
            this._fileDialog = fileDialog;
            this._errorHandler = errorHandler;

            // Commands
            OpenProtocolConfigurationCommand = new AsyncCommand(OnOpenProtocolConfiguration, OpenProtocolConfigurationCanExecute, this._errorHandler);
            GetProtocolConfigurationCommand = new AsyncCommand<string>(execute: OnGetProtocolConfiguration, errorHandler: this._errorHandler);
        }

        #region ProtocolConfiguration commands
        public IAsyncCommand OpenProtocolConfigurationCommand { get; private set; }
        private async Task OnOpenProtocolConfiguration()
        {
            var filePath = _fileDialog.OpenFile();
            if (!string.IsNullOrEmpty(filePath))
            {
                await GetProtocolConfigurationCommand.ExecuteAsync(filePath);
            }
        }
        private bool OpenProtocolConfigurationCanExecute()
        {
            return true;
        }
        public IAsyncCommand<string> GetProtocolConfigurationCommand { get; private set; }
        private async Task OnGetProtocolConfiguration(string filePath)
        {
            try
            {
                ProtocolConfigurationLoading = true;
                // ToDo read file handling
                ProtocolConfigurationPath = filePath;
                Log("Protocol configuration loaded");
            }
            catch
            {
                Log($"Protocol configuration loading error");
                throw;
            }
            finally
            {
                ProtocolConfigurationLoading = false;
            }
        }
        #endregion

        private void Log(string log)
        {
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var logStr = $"{time} | {log}";
            LoggerText += $"{logStr}{Environment.NewLine}";
        }

        private void LogError(string log)
        {
            Log($"ERROR: {log}");
        }

        private void LogNewError(object sender, NewErrorEventArgs e)
        {
            Log($"ERROR: {e.errorMessage}");
        }
    }
}
