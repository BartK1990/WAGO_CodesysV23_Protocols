using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace WAGO_CodesysV23_Protocols.UI.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SetAndNotify<T>(ref T field, T value, Expression<Func<T>> property)
        {
            if (!object.ReferenceEquals(field, value))
            {
                field = value;
                this.OnPropertyChanged(property);
            }
        }

        protected virtual void Notify<T>(T value, Expression<Func<T>> property)
        {
            this.OnPropertyChanged(property);
        }

        protected virtual void OnPropertyChanged<T>(Expression<Func<T>> changedProperty)
        {
            if (PropertyChanged != null)
            {
                string name = ((MemberExpression)changedProperty.Body).Member.Name;
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
