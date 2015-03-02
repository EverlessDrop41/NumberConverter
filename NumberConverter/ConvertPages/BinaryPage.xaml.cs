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
using System.Text.RegularExpressions;

using NumberConverter.Core;

namespace NumberConverter.ConvertPages
{
    /// <summary>
    /// Interaction logic for Binary.xaml
    /// </summary>
    public partial class BinaryPage : UserControl
    {
        TextBox binaryBox;
        TextBox denaryBox;

        public BinaryPage()
        {
            InitializeComponent();
            Switcher.pageSwitcher.Title = "Binary Converter";
            binaryBox = BinaryInputBox;
            denaryBox = DenaryInputBox;
        }

        private void UpdateAnswer(object sender, KeyEventArgs e)
        {
            TextBox currentBox = sender as TextBox;

            if (currentBox.Name == binaryBox.Name)
            {
                if (Checks.IsBinary(BinaryInputBox.Text))
                {
                    denaryBox.Text = Conversion.ToDenary(BinaryInputBox.Text, 2).ToString();
                    BinarySentence.Content = Conversion.binaryToSentence(BinaryInputBox.Text);
                }
                else
                {
                    denaryBox.Text = "Enter a binary number above";
                    BinarySentence.Content = Conversion.binaryToSentence(BinaryInputBox.Text);
                }
            }

            if (currentBox.Name == denaryBox.Name)
            {
                int denaryBoxInt;
                if (Regex.IsMatch(denaryBox.Text, @"^\d+$"))
                {
                    if (int.TryParse(denaryBox.Text, out denaryBoxInt))
                    {
                        binaryBox.Text = Conversion.fromDenary(denaryBoxInt, 2);
                        BinarySentence.Content = Conversion.binaryToSentence(BinaryInputBox.Text);
                    }
                    else 
                    {
                        binaryBox.Text = "Sorry, there was an error; your number was probably too big!";
                    }
                }
                else
                {
                    denaryBox.Text = "Enter a (denary) number below";
                    BinarySentence.Content = Conversion.binaryToSentence(BinaryInputBox.Text);
                }
            }
        }
    }
}
