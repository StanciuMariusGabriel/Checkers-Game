using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TemaDame.Models
{
    public class Stats : INotifyPropertyChanged
    {
        public string statPath = System.IO.Directory.GetParent(Environment.CurrentDirectory.ToString()).FullName + "\\Stats.txt";
        private string redWinsString;
        private string whiteWinsString;
        private string buttonStats;
        public Stats()
        {
            TextReader statFile = File.OpenText(statPath);
            winsWhite = int.Parse(statFile.ReadLine());
            winsRed = int.Parse(statFile.ReadLine());
            redWinsString = winsRed.ToString();
            whiteWinsString = winsWhite.ToString();
            buttonStats = "Show Stats";
            statFile.Close();
        }
        private bool showStats;
        public bool ShowStats
        {
            get { return showStats; }
            set
            {
                showStats = value;
                NotifyPropertyChanged("ShowStats");
            }
        }

        private int winsRed;
        public int WinsRed
        {
            get { return winsRed; }
            set
            {
                winsRed = value;
                NotifyPropertyChanged("WinsRed");
            }
        }

        private int winsWhite;

        public int WinsWhite
        {
            get { return winsWhite; }
            set
            {
                winsWhite = value;
                NotifyPropertyChanged("WinsWhite");
            }
        }

        public string RedWinsString
        {
            get { return redWinsString; }
            set
            {
                redWinsString = value;
                NotifyPropertyChanged("RedWinsString");
            }
        }

        public string WhiteWinsString
        {
            get { return whiteWinsString; }
            set
            {
                whiteWinsString = value;
                NotifyPropertyChanged("WhiteWinsString");
            }
        }
        public string ButtonStats
        {
            get { return buttonStats; }
            set
            {
                buttonStats = value;
                NotifyPropertyChanged("ButtonStats");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        ~Stats()
        {
            using (StreamWriter write = new StreamWriter(statPath))
            {
                write.WriteLine(winsWhite);
                write.WriteLine(winsRed);
            }
        }
    }
}
