using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NumberConverter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_UnhandledException(object sendder, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception occuered: " + e.Exception.Message, "Number Converter Error Box",MessageBoxButton.OK, MessageBoxImage.Error);
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
    /* Un-needed
    public static class numberStrings
    {
        public static List<char> numAsChar
            = new List<char> 
            {
                #region assignment
                    {'0'},
                    {'1'},
                    {'2'},
                    {'3'},
                    {'4'},
                    {'5'},
                    {'6'},
                    {'7'},
                    {'8'},
                    {'9'},
                #endregion
            };

        public static Dictionary<char, int> charToInt
            = new Dictionary<char, int> 
            { 
                #region assignment
                {'0', 0},
                {'1', 1},
                {'2', 2},
                {'3', 3},
                {'4', 4},
                {'5', 5},
                {'6', 6},
                {'7', 7},
                {'8', 8},
                {'9', 9}
                #endregion
            };

        public static Dictionary<int, char> intToChar
            = new Dictionary<int, char> 
            { 
                #region assignment
                {0, '0'},
                {1, '1'},
                {2, '2'},
                {3, '3'},
                {4, '4'},
                {5, '5'},
                {6, '6'},
                {7, '7'},
                {8, '8'},
                {9, '9'}
                #endregion
            };
               
    }
*/
}