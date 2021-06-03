using TemaDame.Models;
using TemaDame.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TemaDame.Utils
{
    public class Logic
    {
        private GameInfo gameInfo;
        private Stats stats;

        public Logic(GameInfo gameInfo, Stats stats)
        {
            this.gameInfo = gameInfo;
            this.stats = stats;
        }
        private int HighlightMove(Cell cell, int possibleMoves = 0, bool multiple = false)
        {
            if (cell.Piece == Piece.WhitePiece || cell.Piece == Piece.WhiteKingPiece || cell.Piece == Piece.RedKingPiece)
            {

                if (cell.X != 7 && cell.Y != 7)
                {
                    if (gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == null && !multiple)
                        gameInfo.Board[cell.X + 1][cell.Y + 1].Highlight = true;

                    else if (cell.Piece != Piece.RedKingPiece && (gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == Piece.RedPiece || gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == Piece.RedKingPiece) && cell.X < 6 && cell.Y < 6)
                    {
                        if (gameInfo.Board[cell.X + 2][cell.Y + 2].Piece == null)
                        {
                            gameInfo.Board[cell.X + 2][cell.Y + 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                    else if (cell.Piece == Piece.RedKingPiece && (gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == Piece.WhitePiece || gameInfo.Board[cell.X + 1][cell.Y + 1].Piece == Piece.WhiteKingPiece) && cell.X < 6 && cell.Y < 6)
                        if (gameInfo.Board[cell.X + 2][cell.Y + 2].Piece == null)
                        {
                            gameInfo.Board[cell.X + 2][cell.Y + 2].Highlight = true;
                            ++possibleMoves;
                        }
                }
                if (cell.X != 7 && cell.Y != 0)
                {
                    if (gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == null && !multiple)
                        gameInfo.Board[cell.X + 1][cell.Y - 1].Highlight = true;
                    else if (cell.Piece != Piece.RedKingPiece && (gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == Piece.RedPiece || gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == Piece.RedKingPiece) && cell.X < 6 && cell.Y > 1)
                    {
                        if (gameInfo.Board[cell.X + 2][cell.Y - 2].Piece == null)
                        {
                            gameInfo.Board[cell.X + 2][cell.Y - 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                    else if (cell.Piece == Piece.RedKingPiece && (gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == Piece.WhitePiece || gameInfo.Board[cell.X + 1][cell.Y - 1].Piece == Piece.WhiteKingPiece) && cell.X < 6 && cell.Y > 1)
                        if (gameInfo.Board[cell.X + 2][cell.Y - 2].Piece == null)
                        {
                            gameInfo.Board[cell.X + 2][cell.Y - 2].Highlight = true;
                            ++possibleMoves;
                        }
                }
            }
            if (cell.Piece == Piece.RedPiece || cell.Piece == Piece.WhiteKingPiece || cell.Piece == Piece.RedKingPiece)
            {
                if (cell.X != 0 && cell.Y != 7)
                {
                    if (gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == null && !multiple)
                        gameInfo.Board[cell.X - 1][cell.Y + 1].Highlight = true;
                    else if (cell.Piece != Piece.WhiteKingPiece && (gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == Piece.WhitePiece || gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == Piece.WhiteKingPiece) && cell.X > 1 && cell.Y < 6)
                    {
                        if (gameInfo.Board[cell.X - 2][cell.Y + 2].Piece == null)
                        {
                            gameInfo.Board[cell.X - 2][cell.Y + 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                    else if (cell.Piece == Piece.WhiteKingPiece && (gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == Piece.RedPiece || gameInfo.Board[cell.X - 1][cell.Y + 1].Piece == Piece.RedKingPiece) && cell.X > 1 && cell.Y < 6)
                        if (gameInfo.Board[cell.X - 2][cell.Y + 2].Piece == null)
                        {
                            gameInfo.Board[cell.X - 2][cell.Y + 2].Highlight = true;
                            ++possibleMoves;
                        }
                }
                if (cell.X != 0 && cell.Y != 0)
                {
                    if (gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == null && !multiple)
                        gameInfo.Board[cell.X - 1][cell.Y - 1].Highlight = true;
                    else if (cell.Piece != Piece.WhiteKingPiece && (gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == Piece.WhitePiece || gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == Piece.WhiteKingPiece) && cell.X > 1 && cell.Y > 1)
                    {
                        if (gameInfo.Board[cell.X - 2][cell.Y - 2].Piece == null)
                        {
                            gameInfo.Board[cell.X - 2][cell.Y - 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                    else if (cell.Piece == Piece.WhiteKingPiece && (gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == Piece.RedPiece || gameInfo.Board[cell.X - 1][cell.Y - 1].Piece == Piece.RedKingPiece) && cell.X > 1 && cell.Y > 1)
                    {
                        if (gameInfo.Board[cell.X - 2][cell.Y - 2].Piece == null)
                        {
                            gameInfo.Board[cell.X - 2][cell.Y - 2].Highlight = true;
                            ++possibleMoves;
                        }
                    }
                }
            }
            return possibleMoves;
        }
        private void ResetHighlight()
        {
            for (int row = 0; row < 8; ++row)
                for (int col = 0; col < 8; ++col)
                    gameInfo.Board[row][col].Highlight = false;
        }

        private void CheckWin()
        {
            int redPieces = 0, whitePieces = 0;
            for (int row = 0; row < 8; ++row)
            {
                for(int col = 0; col < 8; ++col)
                {
                    if (gameInfo.Board[row][col].Piece == Piece.RedPiece || gameInfo.Board[row][col].Piece == Piece.RedKingPiece)
                        ++redPieces;
                    if (gameInfo.Board[row][col].Piece == Piece.WhitePiece || gameInfo.Board[row][col].Piece == Piece.WhiteKingPiece)
                        ++whitePieces;
                }
            }
            if(redPieces == 0)
            {
                ++stats.WinsWhite;
                stats.WhiteWinsString = stats.WinsWhite.ToString();
                gameInfo.WhiteWins = true;
                gameInfo.GameFinished = true;
            }
            else if(whitePieces == 0)
            {
                ++stats.WinsRed;
                stats.RedWinsString = stats.WinsRed.ToString();
                gameInfo.RedWins = true;
                gameInfo.GameFinished = true;
            }
        }

        private void MoveCaptureSimple(Cell currentCell)
        {
            currentCell.Piece = Helper.PreviousCell.Piece;
            Helper.PreviousCell.Piece = null;
            if (Math.Abs(Helper.PreviousCell.X - currentCell.X) != 1)
                if (gameInfo.Board[(Helper.PreviousCell.X + currentCell.X) / 2][(Helper.PreviousCell.Y + currentCell.Y) / 2].Piece != null)
                    gameInfo.Board[(Helper.PreviousCell.X + currentCell.X) / 2][(Helper.PreviousCell.Y + currentCell.Y) / 2].Piece = null;
            if (currentCell.Piece == Piece.RedPiece && currentCell.X == 0)
                currentCell.Piece = Piece.RedKingPiece;
            if (currentCell.Piece == Piece.WhitePiece && currentCell.X == 7)
                currentCell.Piece = Piece.WhiteKingPiece;
            if (gameInfo.StartPhase)
                gameInfo.StartPhase = false;
            CheckWin();
            ResetHighlight();
        }
        public void cellClicked(Cell currentCell, bool multiple = false)
        {
            if (currentCell.Piece != null && ((currentCell.Piece == Piece.WhitePiece && gameInfo.PlayerTurn == false) || (currentCell.Piece == Piece.WhiteKingPiece && gameInfo.PlayerTurn == false))
                || ((currentCell.Piece == Piece.RedPiece && gameInfo.PlayerTurn == true) || (currentCell.Piece == Piece.RedKingPiece && gameInfo.PlayerTurn == true)))
            {
                ResetHighlight();
                HighlightMove(currentCell);
                Helper.PreviousCell = currentCell;
            }
            else if (currentCell.Highlight && Helper.PreviousCell.Piece != null)
            {
                MoveCaptureSimple(currentCell);
                if (gameInfo.MultipleAllowed)
                {
                    if (Math.Abs(Helper.PreviousCell.X - currentCell.X) != 1)
                    {
                        if (HighlightMove(currentCell, 0, true) != 0)
                        {
                            Helper.PreviouslyJumped = true;
                            Helper.PreviousCell = currentCell;
                        }
                        else
                        {
                            gameInfo.PlayerTurn = !gameInfo.PlayerTurn;
                            Helper.PreviouslyJumped = false;
                        }
                    }
                    else
                        gameInfo.PlayerTurn = !gameInfo.PlayerTurn;
                }
                else
                    gameInfo.PlayerTurn = !gameInfo.PlayerTurn;
            }
        }

        public void ClickAction(Cell obj)
        {
            if (!Helper.PreviouslyJumped)
                cellClicked(obj);
            else if (Helper.PreviouslyJumped && obj.Highlight)
                cellClicked(obj);
        }
    }
}
