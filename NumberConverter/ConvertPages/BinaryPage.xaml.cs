using NumberConverter.Core;

using System.Text.RegularExpressions;

using System.Windows.Controls;
using System.Windows.Input;

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
                long denaryBoxInt;
                if (Regex.IsMatch(denaryBox.Text, @"^\d+$"))
                {
                    if (long.TryParse(denaryBox.Text, out denaryBoxInt))
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
