using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaDame.Models;

namespace TemaDame.Utils
{
    class Helper
    {
        public static Cell CurrentCell { get; set; }
        public static Cell PreviousCell { get; set; }
        public static bool PreviouslyJumped { get; set; } = false;
        public static ObservableCollection<ObservableCollection<Cell>> InitGameBoard()
        {
            return new ObservableCollection<ObservableCollection<Cell>>()
            {
                new ObservableCollection<Cell>()
                {
                    new Cell(0, 0, null, false),
                    new Cell(0, 1, Piece.WhitePiece, false),
                    new Cell(0, 2, null, false),
                    new Cell(0, 3, Piece.WhitePiece, false),
                    new Cell(0, 4, null, false),
                    new Cell(0, 5, Piece.WhitePiece, false),
                    new Cell(0, 6, null, false),
                    new Cell(0, 7, Piece.WhitePiece, false)
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(1, 0, Piece.WhitePiece, false),
                    new Cell(1, 1, null, false),
                    new Cell(1, 2, Piece.WhitePiece, false),
                    new Cell(1, 3, null, false),
                    new Cell(1, 4, Piece.WhitePiece, false),
                    new Cell(1, 5, null, false),
                    new Cell(1, 6, Piece.WhitePiece, false),
                    new Cell(1, 7, null, false),
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(2, 0, null, false),
                    new Cell(2, 1, Piece.WhitePiece, false),
                    new Cell(2, 2, null, false),
                    new Cell(2, 3, Piece.WhitePiece, false),
                    new Cell(2, 4, null, false),
                    new Cell(2, 5, Piece.WhitePiece, false),
                    new Cell(2, 6, null, false),
                    new Cell(2, 7, Piece.WhitePiece, false)
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(3, 0, null, false),
                    new Cell(3, 1, null, false),
                    new Cell(3, 2, null, false),
                    new Cell(3, 3, null, false),
                    new Cell(3, 4, null, false),
                    new Cell(3, 5, null, false),
                    new Cell(3, 6, null, false),
                    new Cell(3, 7, null, false)
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(4, 0, null, false),
                    new Cell(4, 1, null, false),
                    new Cell(4, 2, null, false),
                    new Cell(4, 3, null, false),
                    new Cell(4, 4, null, false),
                    new Cell(4, 5, null, false),
                    new Cell(4, 6, null, false),
                    new Cell(4, 7, null, false)
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(5, 0, Piece.RedPiece, false),
                    new Cell(5, 1, null, false),
                    new Cell(5, 2, Piece.RedPiece, false),
                    new Cell(5, 3, null, false),
                    new Cell(5, 4, Piece.RedPiece, false),
                    new Cell(5, 5, null, false),
                    new Cell(5, 6, Piece.RedPiece, false),
                    new Cell(5, 7, null, false),
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(6, 0, null, false),
                    new Cell(6, 1, Piece.RedPiece, false),
                    new Cell(6, 2, null, false),
                    new Cell(6, 3, Piece.RedPiece, false),
                    new Cell(6, 4, null, false),
                    new Cell(6, 5, Piece.RedPiece, false),
                    new Cell(6, 6, null, false),
                    new Cell(6, 7, Piece.RedPiece, false),
                },
                new ObservableCollection<Cell>()
                {
                    new Cell(7, 0, Piece.RedPiece, false),
                    new Cell(7, 1, null, false),
                    new Cell(7, 2, Piece.RedPiece, false),
                    new Cell(7, 3, null, false),
                    new Cell(7, 4, Piece.RedPiece, false),
                    new Cell(7, 5, null, false),
                    new Cell(7, 6, Piece.RedPiece, false),
                    new Cell(7, 7, null, false),
                }
            };
        }
    }
}
