﻿using System;
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

using Xceed.Wpf.Toolkit;

namespace NumberConverter.ConvertPages
{
    /// <summary>
    /// Interaction logic for HexadecimalPage.xaml
    /// </summary>
    public partial class HexadecimalPage : UserControl
    {
        TextBox HexBox;
        ColorPicker colorPicker;

        public HexadecimalPage()
        {
            InitializeComponent();
        }

        private void UpdateAnswerFromTextInput(object sender, KeyEventArgs e)
        {
            //ColorInput.SelectedColor = Color.;
        }
    }
}
