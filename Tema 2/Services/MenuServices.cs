using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tema_2.ViewModels;
using Tema_2.Views;

namespace Tema_2.Services
{
    internal class MenuServices
    {
        public void NewGame()
        {
            foreach (Window window in Application.Current.Windows)
            {
                // Check if the window is currently active or has focus
                if (window.IsActive || window.IsFocused)
                {
                    if (window.Name == "Menu")
                    {
                        NewGame newGame = new NewGame();
                        newGame.Show();
                        window.Close(); 
                         
                    }
                }
                
            }
            //MessageBox.Show("okes");
        }
    }
}
