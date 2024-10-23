using Logic;
using System.Windows;
using ViewModels;

namespace TD01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonData data;
        private DirectoryVM viewModel;
        
        public MainWindow()
        {
            InitializeComponent();
            this.data = new MockDataLayer();
            this.viewModel = new DirectoryVM(data);
            this.DataContext = viewModel;
            
        }

        private async void AddPerson(object sender, RoutedEventArgs e)
        {
            

        }

        private async void RemovePerson(object sender, RoutedEventArgs e)
        {
            
        }
    }
}