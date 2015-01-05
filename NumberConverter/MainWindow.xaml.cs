using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using NumberConverter.ConvertPages;

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
            Switcher.Navigate(new NumberConverter.ConvertPages.TestPage());
        } 
  
        private void GotoBinaryPage(object sender, RoutedEventArgs e)
        {
            Switcher.Navigate(new NumberConverter.ConvertPages.TestPage());
        }   

        private void GotoHexidecimalPage(object sender, RoutedEventArgs e)
        {
            Switcher.Navigate(new NumberConverter.ConvertPages.TestPage());
        }   

    }
}
