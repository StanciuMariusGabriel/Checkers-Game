using TemaDame.Models;
using TemaDame.Commands;
using TemaDame.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;

namespace TemaDame.ViewModels
{
    public class GameVM : INotifyPropertyChanged
    {
        //private Logic boardLogic;
        private NewGameCommand newGameCommand;
        private SaveGameCommand saveGameCommand;
        private LoadGameCommand loadGameCommand;
        private ShowStatsCommand showStatsCommand;
        private AboutCommand aboutCommand;
        public GameVM()
        {
            ObservableCollection<ObservableCollection<Cell>> board = Helper.InitGameBoard();
            GameInfo = new GameInfo(board, false, false, false, false, false, true);
            Stats = new Stats();
            GameBoard = CellBoardToCellVMBoard(board);
            newGameCommand = new NewGameCommand(this);
            saveGameCommand = new SaveGameCommand(this);
            loadGameCommand = new LoadGameCommand(this);
            showStatsCommand = new ShowStatsCommand(this);
            aboutCommand = new AboutCommand();
        }
       
        public ObservableCollection<ObservableCollection<CellVM>> CellBoardToCellVMBoard(ObservableCollection<ObservableCollection<Cell>> board)
        {
            ObservableCollection<ObservableCollection<CellVM>> result = new ObservableCollection<ObservableCollection<CellVM>>();
            for (int i = 0; i < board.Count; i++)
            {
                ObservableCollection<CellVM> line = new ObservableCollection<CellVM>();
                for (int j = 0; j < board[i].Count; j++)
                {
                    Cell cell = board[i][j];
                    CellVM cellVM = new CellVM(cell, new Logic(GameInfo, Stats));
                    line.Add(cellVM);
                }
                result.Add(line);
            }
            return result;
        }
        public ICommand NewGameCommand
        {
            get
            {
                return newGameCommand;
            }
        }

        public ICommand SaveGameCommand
        {
            get
            {
                return saveGameCommand;
            }
        }

        public ICommand LoadGameCommand
        {
            get
            {
                return loadGameCommand;
            }
        }
        public ICommand ShowStatsCommand
        {
            get
            {
                return showStatsCommand;
            }
        }

        public ICommand AboutCommand
        {
            get
            {
                return aboutCommand;
            }
        }
        private ObservableCollection<ObservableCollection<CellVM>> gameBoard;

        public ObservableCollection<ObservableCollection<CellVM>> GameBoard
        {
            get { return gameBoard; }
            set
            {
                gameBoard = value;
                NotifyPropertyChanged("GameBoard");
            }
        }

        private GameInfo gameInfo;

        public GameInfo GameInfo
        {
            get { return gameInfo; }
            set
            {
                gameInfo = value;
                NotifyPropertyChanged("GameInfo");
            }
        }

        private Stats stats;

        public Stats Stats
        {
            get { return stats; }
            set
            {
                stats = value;
                NotifyPropertyChanged("Stats");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
