using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WAGO_CodesysV23_Protocols.UI.ViewModel.Command
{
    using ViewModel.Service;

    public class AsyncCommand : IAsyncCommand
    {
        public event EventHandler CanExecuteChanged;

        private bool _isExecuting;
        private readonly IErrorHandler _errorHandler;
        private readonly Func<Task> _execute;
        private readonly Func<bool> _canExecute;

        public AsyncCommand(Func<Task> execute, Func<bool> canExecute = null, IErrorHandler errorHandler = null)
        {
            _execute = execute;
            _canExecute = canExecute;
            _errorHandler = errorHandler;
        }

        public bool CanExecute()
        {
            return !_isExecuting && (_canExecute?.Invoke() ?? true);
        }

        public async Task ExecuteAsync()
        {
            if (CanExecute())
            {
                try
                {
                    _isExecuting = true;
                    RaiseCanExecuteChanged();
                    await _execute();
                }
                catch(Exception ex)
                {
                    _errorHandler?.HandleError(ex);
                }
                finally
                {
                    _isExecuting = false;
                }
            }
            RaiseCanExecuteChanged();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        #region Explicit implementations
        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute();
        }

        void ICommand.Execute(object parameter)
        {
            _ = ExecuteAsync();
        }
        #endregion
    }

    public class AsyncCommand<T> : IAsyncCommand<T>
    {
        public event EventHandler CanExecuteChanged;

        private bool _isExecuting;
        private readonly Func<T, Task> _executeOfT;
        private readonly Func<bool> _canExecute;
        private readonly Func<T, bool> _canExecuteOfT;
        private readonly IErrorHandler _errorHandler;

        public AsyncCommand(Func<T, Task> execute, IErrorHandler errorHandler = null)
        {
            _executeOfT = execute;
            _errorHandler = errorHandler;
        }

        public AsyncCommand(Func<T, Task> execute, Func<bool> canExecute = null, IErrorHandler errorHandler = null)
        {
            _executeOfT = execute;
            _canExecute = canExecute;
            _errorHandler = errorHandler;
        }

        public AsyncCommand(Func<T, Task> execute, Func<T, bool> canExecute = null, IErrorHandler errorHandler = null)
        {
            _executeOfT = execute;
            _canExecuteOfT = canExecute;
            _errorHandler = errorHandler;
        }

        public bool CanExecute()
        {
            return !_isExecuting && (_canExecute?.Invoke() ?? true);
        }

        public bool CanExecute(T parameter)
        {
            return !_isExecuting && (_canExecuteOfT?.Invoke(parameter) ?? true);
        }

        public async Task ExecuteAsync(T parameter)
        {
            if (CanExecute(parameter))
            {
                try
                {
                    _isExecuting = true;
                    RaiseCanExecuteChanged();
                    await _executeOfT(parameter);
                }
                catch (Exception ex)
                {
                    _errorHandler?.HandleError(ex);
                }
                finally
                {
                    _isExecuting = false;
                }
            }

            RaiseCanExecuteChanged();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        #region Explicit implementations
        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute((T)parameter);
        }

        void ICommand.Execute(object parameter)
        {
            _ = ExecuteAsync((T)parameter);
        }
        #endregion
    }
}
