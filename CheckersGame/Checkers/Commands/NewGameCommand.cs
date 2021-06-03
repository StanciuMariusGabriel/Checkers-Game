using TemaDame.ViewModels;
using TemaDame.Utils;
using TemaDame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace TemaDame.Commands
{
    class NewGameCommand : ICommand
    {
        private GameVM gameVM;
        public NewGameCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        public void NewGame()
        {
            ObservableCollection<ObservableCollection<Cell>> board = Helper.InitGameBoard();
            gameVM.GameInfo = new GameInfo(board, gameVM.GameInfo.MultipleAllowed, false, false, false, false, true);
            gameVM.GameBoard = gameVM.CellBoardToCellVMBoard(board);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            NewGame();
        }

        public event EventHandler CanExecuteChanged;
    }
}
