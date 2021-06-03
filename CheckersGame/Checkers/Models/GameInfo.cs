using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TemaDame.Models
{
    [Serializable]
    public class GameInfo : INotifyPropertyChanged
    {
        public GameInfo() { }
        public GameInfo(ObservableCollection<ObservableCollection<Cell>> board, bool multipleAllowed, bool playerTurn, bool whiteWins, bool redWins, bool gameFinished, bool startPhase)
        {
            this.board = board;
            this.multipleAllowed = multipleAllowed;
            this.playerTurn = playerTurn;
            this.whiteWins = whiteWins;
            this.redWins = redWins;
            this.gameFinished = gameFinished;
            this.startPhase = startPhase;
        }

        private ObservableCollection<ObservableCollection<Cell>> board;

        public ObservableCollection<ObservableCollection<Cell>> Board
        {
            get { return board; }
            set
            {
                board = value;
                NotifyPropertyChanged("Board");
            }

        }

        private bool multipleAllowed;
        public bool MultipleAllowed
        {
            get { return multipleAllowed; }
            set
            {
                multipleAllowed = value;
                NotifyPropertyChanged("MultipleAllowed");
            }
        }

        private bool playerTurn;
        public bool PlayerTurn
        {
            get { return playerTurn; }
            set
            {
                playerTurn = value;
                NotifyPropertyChanged("PlayerTurn");
            }
        }
        private bool whiteWins;
        public bool WhiteWins
        {
            get { return whiteWins; }
            set
            {
                whiteWins = value;
                NotifyPropertyChanged("WhiteWins");
            }
        }
        private bool redWins;
        public bool RedWins
        {
            get { return redWins; }
            set
            {
                redWins = value;
                NotifyPropertyChanged("RedWins");
            }
        }
        private bool gameFinished;
        public bool GameFinished
        {
            get { return gameFinished; }
            set
            {
                gameFinished = value;
                NotifyPropertyChanged("GameFinished");
            }
        }

        private bool startPhase;
        public bool StartPhase
        {
            get { return startPhase; }
            set
            {
                startPhase = value;
                NotifyPropertyChanged("StartPhase");
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
