using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Tema_2.Commands;

namespace Tema_2.Model
{
    class Cell : BaseNotification
    {
        static private bool isRedMoving= true;
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; NotifyPropertyChanged("X"); }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; NotifyPropertyChanged("Y"); }
        }
        private Brush _cellColor;
        public Brush CellColor
        {
            get { return _cellColor; }
            set { _cellColor = value; NotifyPropertyChanged("Color"); }
        }
        private PiecesEnum _pieceEnum;
        public PiecesEnum PieceEnum
        {
            get { return _pieceEnum; }
            set { _pieceEnum = value; NotifyPropertyChanged("PieceEnum"); }
        }
        private string _piecePath;
        public string PiecePath
        {
            get { return _piecePath; }
            set { _piecePath = value; NotifyPropertyChanged("PiecePath"); }
        }

        public bool CanExecuteCommand { get; set; } = true;

        private ICommand _selectPiece;
        public ICommand SelectPieceCommand
        {
            get

            {
                if (_selectPiece == null)
                {
                    _selectPiece = new RelayCommand(SelectPiece);
                }
                return _selectPiece;
            }

        }
        static private Cell selectedCell;

      

        private void SelectPiece()
        {
            if (selectedCell != null)
            {
                if (selectedCell.PieceEnum != PiecesEnum.none)
                {
                    if (isRedMoving == true)
                    {
                        if (this.PieceEnum == PiecesEnum.none)
                        {
                            if (this.Y == selectedCell.Y + 1 && (this.X == selectedCell.X + 1 || this.X == selectedCell.X - 1))
                            {
                                this.PieceEnum = selectedCell.PieceEnum;
                                this.PiecePath = selectedCell.PiecePath;
                                selectedCell.PiecePath = null;
                                selectedCell.PieceEnum = PiecesEnum.none;
                                isRedMoving = false;
                            }
                        }
                    }
                }
            }
            else
            {
                if ((this.PieceEnum == PiecesEnum.red || this.PieceEnum == PiecesEnum.redKing)&& isRedMoving == true)
                {
                    selectedCell = this;
                }
                else if ((this.PieceEnum == PiecesEnum.black || this.PieceEnum == PiecesEnum.black) && isRedMoving == false)
                {
                    selectedCell = this;
                }
            }
            //if ((this.PieceEnum == PiecesEnum.red || this.PieceEnum == PiecesEnum.redKing)/*&& redPlayerRound=true*/)
            //{
            //    selectedCell = this;
            //}

        }
    }
}
