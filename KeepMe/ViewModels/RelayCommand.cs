using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KeepMe.ViewModels
{
    /// <summary>
    /// The class for the Commands
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// The action to be done
        /// </summary>
        private Action action;

        /// <summary>
        /// The action to be done with some additional parameter
        /// </summary>
        private Action<string> _action;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        /// <summary>
        /// Paremeterized Constructor
        /// </summary>
        /// <param name="action">Default action</param>
        public RelayCommand(Action action)
        {
            this.action = action;
        }

        /// <summary>
        /// Paremeterized Constructor
        /// </summary>
        /// <param name="action">Action with some parameter to take account</param>
        public RelayCommand(Action<string> action)
        {
            _action = action;
        }

        // The constructor was overloaded with 2 method with different arguments to be passed

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (action != null)
                action();
            else
                _action(parameter.ToString());
        }
    }
}
