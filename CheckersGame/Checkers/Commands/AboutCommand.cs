using TemaDame.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TemaDame.Commands
{
    class AboutCommand : ICommand
    {
        public AboutCommand() { }

        public void ShowAbout()
        {
            About aboutWindow = new About();
            aboutWindow.Show();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowAbout();
        }

        public event EventHandler CanExecuteChanged;
    }
}
