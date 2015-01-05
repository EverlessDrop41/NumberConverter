using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using NumberConverter.Core;

namespace NumberConverter.ConvertPages
{
    /// <summary>
    /// Interaction logic for TestPage.xaml
    /// </summary>
    public partial class TestPage : UserControl
    {
        public TestPage()
        {
            InitializeComponent();
            Switcher.pageSwitcher.Title = "Test Page";
        }

        private void UpdateAnswer(object sender, KeyEventArgs e)
        {
            if (Checks.IsBinary(InputBox.Text))
            {
                AnswerBox.Content = Conversion.ToDenary(InputBox.Text, 2);
                BinarySentence.Content = Conversion.binaryToSentence(InputBox.Text);
            }
            else 
            {
                AnswerBox.Content = "Enter a binary number";
                BinarySentence.Content = Conversion.binaryToSentence(InputBox.Text);
            }
        }
    }
}
