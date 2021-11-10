﻿using System;
using System.Threading.Tasks;
using WAGO_CodesysV23_Protocols.Model.Type;
using WAGO_CodesysV23_Protocols.UI.Data.Repository;
using WAGO_CodesysV23_Protocols.UI.Event;
using WAGO_CodesysV23_Protocols.UI.View.Services;
using WAGO_CodesysV23_Protocols.UI.ViewModel.Command;
using WAGO_CodesysV23_Protocols.UI.ViewModel.Service;

namespace WAGO_CodesysV23_Protocols.UI.ViewModel
{
    internal class ConverterXmlExcelViewModel : ViewModelBase
    {
        private readonly IExcelXmlFileDialog _fileDialog;
        private readonly IErrorHandler _errorHandler;
        private readonly IIec608705ObjectsReadRepository _iec608705ObjectsReadRepository;
        private readonly IIec608705ConnectionsReadRepository _iec608705ConnectionsReadRepository;
        private readonly IIec608705MainConfigurationReadRepository _iec608705MainConfigurationReadRepository;
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

        internal ConverterXmlExcelViewModel(IExcelXmlFileDialog fileDialog, 
            IErrorHandler errorHandler,
            IIec608705ObjectsReadRepository iec608705ObjectsReadRepository,
            IIec608705ConnectionsReadRepository iec608705ConnectionsReadRepository,
            IIec608705MainConfigurationReadRepository iec608705MainConfigurationReadRepository
            )
        {
            this._fileDialog = fileDialog;
            this._errorHandler = errorHandler;
            this._errorHandler.NewError += LogNewError;
            this._iec608705ObjectsReadRepository = iec608705ObjectsReadRepository;
            this._iec608705ConnectionsReadRepository = iec608705ConnectionsReadRepository;
            this._iec608705MainConfigurationReadRepository = iec608705MainConfigurationReadRepository;

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
                var objects = await _iec608705ObjectsReadRepository.ReadDataAsync(filePath);
                var connections = await _iec608705ConnectionsReadRepository.ReadDataAsync(filePath);
                var mainConfiguration = await _iec608705MainConfigurationReadRepository.ReadDataAsync(filePath);
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
