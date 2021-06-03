using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TemaDame.Models
{
    public class Cell : INotifyPropertyChanged
    {
        public Cell()
        {

        }
        public Cell(int x, int y, string piece, bool highlight)
        {
            this.X = x;
            this.Y = y;
            this.piece = piece;
            this.highlight = highlight;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private int x;
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                NotifyPropertyChanged("X");
            }
        }
        private int y;
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                NotifyPropertyChanged("Y");
            }
        }
        private string piece;
        public string Piece
        {
            get { return piece; }
            set
            {
                piece = value;
                NotifyPropertyChanged("Piece");
            }
        }
        private bool highlight;
        [XmlIgnore]
        public bool Highlight
        {
            get { return highlight; }
            set
            {
                highlight = value;
                NotifyPropertyChanged("Highlight");
            }
        }
    }
}
