using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FinOrganizer.mvvm
{
    public class BankTransaction : INotifyPropertyChanged
    {
        private int _quantity;
        private DateTime _time;

        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        public DateTime Time
        {
            get => _time;
            set
            {
                _time = value;
                OnPropertyChanged("Time");
            }
        }

        public BankTransaction()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
