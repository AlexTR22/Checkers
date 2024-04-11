using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tema_2.Commands
{
    class RelayCommandsTemplate : ICommand
    {
        private Action<object> commandTask;
        private Predicate<object> canExecuteTask;

        public RelayCommandsTemplate(Action<object> workToDo, Predicate<object> canExecute)
        {
            commandTask = workToDo;
            canExecuteTask = canExecute;
        }

        public RelayCommandsTemplate(Action<object> workToDo)
            : this(workToDo, DefaultCanExecute)
        {
            commandTask = workToDo;
        }

        private static bool DefaultCanExecute(object parameter)
        {
            return true;
        }

        public bool CanExecute(object parameter)
        {
            return canExecuteTask != null && canExecuteTask((object)parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                //+=asociaza un handler la un eveniment
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                //-=sterge un handler de la un eveniment
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            commandTask((object)parameter);
        }
    }
}
