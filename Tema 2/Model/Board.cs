using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tema_2.Model
{
    class Board :BaseNotification
    {
        public Board()
        {
            for(int i = 0; i < 8; i++) 
            {
                for (int j = 0; j < 8; j++)
                {
                    Cell cell = new Cell();
                    if (j % 2 == 0)
                    {
                        if (i % 2 == 0)
                        {
                            cell.CellColor = new SolidColorBrush(Colors.White);
                        }
                        else
                        {
                            cell.CellColor = new SolidColorBrush(Colors.Black);
                        }
                    }
                    else
                    {
                        if (i % 2 == 1)
                        {
                            cell.CellColor = new SolidColorBrush(Colors.White);
                        }
                        else
                        {
                            cell.CellColor = new SolidColorBrush(Colors.Black);
                        }
                    }
                }
            }
        }

        private ObservableCollection<ObservableCollection<Cell>> _cells;
        public ObservableCollection<ObservableCollection<Cell>>  Cells
        {
            get { return _cells; } 
            set { _cells = value; NotifyPropertyChanged("Cells"); }
        }

        private ObservableCollection<Piece> _piece;
        public ObservableCollection<Piece> Pieces
        {   
            get { return _piece; }
            set { _piece = value; NotifyPropertyChanged("Pieces"); }
        }
    }
}
