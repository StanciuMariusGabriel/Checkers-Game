using TemaDame.Models;
using TemaDame.Commands;
using TemaDame.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TemaDame.ViewModels
{
    public class CellVM : BaseNotification
    {
        Logic boardLogic;
        public CellVM(Cell cell, Logic boardLogic)
        {
            SimpleCell = cell;
            this.boardLogic = boardLogic;
        }
        private Cell simpleCell;
        public Cell SimpleCell
        {
            get { return simpleCell; }
            set
            {
                simpleCell = value;
                NotifyPropertyChanged("SimpleCell");
            }
        }
        private ICommand clickCommand;
        public ICommand ClickCommand
        {
            get
            {
                if (clickCommand == null)
                {
                    clickCommand = new RelayCommand<Cell>(boardLogic.ClickAction);
                }
                return clickCommand;
            }
        }
    }
}
