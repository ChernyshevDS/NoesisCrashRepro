using System;
using System.Windows.Input;

namespace ViewModels
{
    public class DelegateCommand : ICommand
    {
        private Action _executeMethod;

        private Func<bool> _canExecuteMethod;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action executeMethod)
            : this(executeMethod, () => true)
        {
        }

        public DelegateCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            if (executeMethod == null || canExecuteMethod == null)
            {
                throw new ArgumentNullException("executeMethod");
            }

            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }

        public void Execute(object parameter) => _executeMethod();

        public bool CanExecute(object parameter) => _canExecuteMethod();

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
