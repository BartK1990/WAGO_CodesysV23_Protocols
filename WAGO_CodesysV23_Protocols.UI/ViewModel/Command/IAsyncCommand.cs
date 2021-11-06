using System.Threading.Tasks;
using System.Windows.Input;

namespace WAGO_CodesysV23_Protocols.UI.ViewModel.Command
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync();
        void RaiseCanExecuteChanged();
    }

    public interface IAsyncCommand<T> : ICommand
    {
        Task ExecuteAsync(T parameter);
        bool CanExecute(T parameter);
        void RaiseCanExecuteChanged();
    }
}
