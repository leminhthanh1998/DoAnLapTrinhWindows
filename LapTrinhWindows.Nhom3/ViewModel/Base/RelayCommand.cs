using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LapTrinhWindows.Nhom3
{
    class RelayCommand:ICommand
    {
        //1 bien action
        private Action _action;

        public RelayCommand(Action action)
        {
            _action = action;
        }

        #region Command method

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged;

        #endregion
    }
}
