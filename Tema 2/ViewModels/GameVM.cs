using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xaml;
using Tema_2.Commands;
using Tema_2.Model;
using Tema_2.Services;
using Tema_2.Views;

namespace Tema_2.ViewModels
{
    internal class GameVM
    {
        private GameServices gameServices;
        public GameVM()
        {
            Cells = new ObservableCollection<ObservableCollection<Cell>>();
            for (int i = 0; i < 8; i++)
            {
                ObservableCollection<Cell> line = new ObservableCollection<Cell>();
                
                for (int j = 0; j < 8; j++)
                {
                    Cell cell = new Cell();
                    if (j % 2 == 0)
                    {
                        if (i % 2 == 0)
                        {
                            cell.CellColor = new SolidColorBrush(Colors.White);
                            cell.X = i;
                            cell.Y = j;
                            cell.PieceEnum = PiecesEnum.none;
                            line.Add(cell);
                        }
                        else
                        {
                            cell.CellColor = new SolidColorBrush(Colors.Gray);
                            cell.X = i;
                            cell.Y = j;
                            if (i < 3)
                            {
                                cell.PieceEnum = PiecesEnum.red;
                                cell.PiecePath = "C:\\Users\\Milcu\\Documents\\MAP\\Tema 2\\Checkers.git\\Tema 2\\RedPawn.png";
                              
                            }
                            else if(i>=5)
                            {
                                cell.PieceEnum = PiecesEnum.black;
                                cell.PiecePath = "C:\\Users\\Milcu\\Documents\\MAP\\Tema 2\\Checkers.git\\Tema 2\\BlackPawn.png";
                                
                            }
                            line.Add(cell);
                        }
                    }
                    else
                    {
                        if (i % 2 == 1)
                        {
                            cell.CellColor = new SolidColorBrush(Colors.White);
                            cell.X = i;
                            cell.Y = j;
                            cell.PieceEnum = PiecesEnum.none;
                            line.Add(cell);
                        }
                        else
                        {
                            cell.CellColor = new SolidColorBrush(Colors.Gray);
                            cell.X = i;
                            cell.Y = j;
                            if (i < 3)
                            {
                                cell.PieceEnum = PiecesEnum.red;
                                cell.PiecePath = "C:\\Users\\Milcu\\Documents\\MAP\\Tema 2\\Checkers.git\\Tema 2\\RedPawn.png";
                             
                            }
                            else if (i >= 5)
                            {
                                cell.PieceEnum = PiecesEnum.black;
                                cell.PiecePath = "C:\\Users\\Milcu\\Documents\\MAP\\Tema 2\\Checkers.git\\Tema 2\\BlackPawn.png";
                              
                            }
                            line.Add(cell);
                        }
                    }

                }
                Cells.Add(line);
            }

            //selectedCell = new Cell();
            gameServices = new GameServices();
        }
        public ObservableCollection<ObservableCollection<Cell>> Cells { get; set; }

       
        //private ICommand _moveBlackPiece;
        //public ICommand MoveBlackPiece
        //{
        //    get
        //    {
        //        if (_moveBlackPiece == null)
        //        {
        //            _moveBlackPiece = new RelayCommand(gameServices.NewGame, param => CanExecuteCommand);
        //        }
        //        return _moveBlackPiece;

        //    }
        //}
    }
}
