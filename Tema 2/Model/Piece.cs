using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tema_2.Model
{
    internal class Piece : BaseNotification
    {
        public Piece(Brush color)
        {
            PieceColor = color;
        }

        private Brush _pieceColor;
        public Brush PieceColor
        {
            get 
            { 
                return _pieceColor;
            }
            set 
            { 
                _pieceColor = value; 
                NotifyPropertyChanged("Color");
            }
        }
        
    }
}
