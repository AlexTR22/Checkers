using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Tema_2.Model;
using Tema_2.Services;

namespace Tema_2.ViewModels
{
    internal class MenuVM : BaseNotification
    {
        private MenuServices menuServices;
        public MenuVM()
        {
            menuServices = new MenuServices();
        }

        public bool CanExecuteCommand { get; set; } = true;

        private ICommand _newGame;
        public ICommand NewGame
        {
            get
            {
                if (_newGame == null)
                {

                    _newGame = new RelayCommand(menuServices.NewGame, param => CanExecuteCommand);
                }
                return _newGame;
                    
            }
        }
       
    }
}
