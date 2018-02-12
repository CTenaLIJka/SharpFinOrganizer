using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace FinOrganizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Operation> List { get; set; }

        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();

            List = new ObservableCollection<Operation>();
            List.Add(new Operation()
            {
                sign = true,
                cost = 450,
                date = DateTime.Now.Date
            });

            List.Add(new Operation()
            {
                sign = true,
                cost = 500,
                date = DateTime.Now.Date
            });

           
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void clickAdd(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
