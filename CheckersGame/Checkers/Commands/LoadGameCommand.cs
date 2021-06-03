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
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;

namespace TemaDame.Commands
{
    class LoadGameCommand : ICommand
    {
        private GameVM gameVM;
        public LoadGameCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        public void LoadGame()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if(openFileDialog.ShowDialog() == true)
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(GameInfo));
                FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open);
                gameVM.GameInfo = xmlser.Deserialize(file) as GameInfo;
                gameVM.GameBoard = gameVM.CellBoardToCellVMBoard(gameVM.GameInfo.Board);
                file.Dispose();
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            LoadGame();
        }

        public event EventHandler CanExecuteChanged;
    }
}
