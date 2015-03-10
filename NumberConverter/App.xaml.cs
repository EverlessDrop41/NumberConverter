using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using NumberConverter.Core;

namespace NumberConverter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_UnhandledException(object sendder, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception occuered: " + e.Exception.Message, "Number Converter Error Box", MessageBoxButton.OK, MessageBoxImage.Error);
            Console.WriteLine("Unhandled error detected!");
        }
    }

    public class Switcher
    {
        public static MainWindow pageSwitcher;

        public static void Navigate(UserControl nextPage)
        {
            if (pageSwitcher != null)
            {
                pageSwitcher.Navigate(nextPage);
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }

    public class RGBColor
    {
        public int Red;
        public int Green;
        public int Blue;

        public void SetFromHex(string HexString)
        {
            if (Checks.IsHexColor(HexString))
            {
                //Do MAGIC
            }
            else
            {
                throw new Exception("String is not a hexadecimal color");
            }
        }
    }
}