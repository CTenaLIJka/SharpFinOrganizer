using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using FinOrganizer.Annotations;
using System.Windows.Input;

namespace FinOrganizer.mvvm
{
    public class OrganizerViewModel : INotifyPropertyChanged
    {
        private BankTransaction _selectedTransaction;
        public string NewTransactionQuantity { get;  set; }

        public BankTransaction SelectedTransaction
        {
            get => _selectedTransaction;
            set
            {
                _selectedTransaction = value;
                OnPropertyChanged("SelectedTransaction");
            }
        }

        public ObservableCollection<BankTransaction> BankTransactions { get; set; }

        private RelayCommand _addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                       (_addCommand = new RelayCommand(obj =>
                       {
                           try
                           {
                               BankTransaction transaction = new BankTransaction();
                               int newQuantity = int.Parse(NewTransactionQuantity);
                               transaction.Quantity = newQuantity;
                               transaction.Time = DateTime.Now;
                               BankTransactions.Insert(0, transaction);
                               SelectedTransaction = transaction;
                           }
                           catch (Exception)
                           {
                               
                           }
                       }));
            }
        }

        public OrganizerViewModel()
        {
            BankTransactions = new ObservableCollection<BankTransaction>
            {
                new BankTransaction {Quantity = 200, Time = DateTime.Parse("1.02.03")},
                new BankTransaction {Quantity = 300, Time = DateTime.Parse("2.02.03")},
                new BankTransaction {Quantity = 400, Time = DateTime.Parse("3.02.03")},
                new BankTransaction {Quantity = 700, Time = DateTime.Parse("4.02.03")},
            };
            NewTransactionQuantity = String.Empty;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
