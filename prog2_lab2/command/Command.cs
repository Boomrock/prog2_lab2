using System;
using System.Windows.Input;

namespace prog2_lab2.command
{
    class Command : ICommand
    {
        private Action _execute;
        public event EventHandler CanExecuteChanged;
        
        public Command( Action execute )
        {
            _execute = execute;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
