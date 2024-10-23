using System.Windows;

namespace TD01
{
    /// <summary>
    /// Logique d'interaction pour PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        public PersonWindow()
        {
            InitializeComponent();
            
        }

        private void Validate(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
