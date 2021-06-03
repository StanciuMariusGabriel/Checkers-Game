using TemaDame.ViewModels;
using TemaDame.Utils;
using TemaDame.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using System.Windows.Input;

namespace TemaDame.Commands
{
    class ShowStatsCommand : ICommand
    {
        private GameVM gameVM;
        public ShowStatsCommand(GameVM gameVM)
        {
            this.gameVM = gameVM;
        }

        public void ShowStats()
        {
            gameVM.Stats.ShowStats = !gameVM.Stats.ShowStats;
            if (gameVM.Stats.ShowStats)
                gameVM.Stats.ButtonStats = "Hide Stats";
            else
                gameVM.Stats.ButtonStats = "Show Stats";
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowStats();
        }

        public event EventHandler CanExecuteChanged;
    }
}
