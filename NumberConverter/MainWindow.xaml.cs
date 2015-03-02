using System.Windows;
using System.Windows.Controls;


namespace NumberConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml, This window is the home
    /// </summary>
    public partial class MainWindow :  Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
        }

        public void Navigate(UserControl newPage) 
        {
            this.Content = newPage;
        }

        private void GotoDenaryPage(object sender, RoutedEventArgs e)
        {
            Switcher.Navigate(new NumberConverter.ConvertPages.BinaryPage());
        } 
  
        private void GotoBinaryPage(object sender, RoutedEventArgs e)
        {
            Switcher.Navigate(new NumberConverter.ConvertPages.BinaryPage());
        }   

        private void GotoHexidecimalPage(object sender, RoutedEventArgs e)
        {
            Switcher.Navigate(new NumberConverter.ConvertPages.BinaryPage());
        }   

    }
}
