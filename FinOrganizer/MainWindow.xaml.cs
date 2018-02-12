namespace FinOrganizer
{
    using System.Windows;

    using mvvm;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            this.DataContext = new OrganizerViewModel();

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
