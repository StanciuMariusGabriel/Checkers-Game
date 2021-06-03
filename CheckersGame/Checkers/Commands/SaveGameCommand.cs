using TemaDame.ViewModels;
using TemaDame.Utils;
using TemaDame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Xml.Serialization;
using System.IO;
using Microsoft.Win32;

namespace TemaDame.Commands
{
    class SaveGameCommand : ICommand
    {
        private GameVM gameVM;
        public SaveGameCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        public void SaveGame()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == true)
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(GameInfo));
                FileStream fileStr = new FileStream(saveFileDialog.FileName, FileMode.Create);
                xmlser.Serialize(fileStr, gameVM.GameInfo);
                fileStr.Close();
                fileStr.Dispose();
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SaveGame();
        }

        public event EventHandler CanExecuteChanged;
    }
}
