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

namespace L3WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBlock != null)
                textBlock.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBlock != null)
                textBlock.FontSize = fontSize;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock !=null)
            {
                if (textBlock.FontWeight == FontWeights.Bold)
                    textBlock.FontWeight = FontWeights.Normal;
                else
                    textBlock.FontWeight = FontWeights.Bold;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBlock != null)
            {
                if (textBlock.FontStyle == FontStyles.Italic)
                    textBlock.FontStyle = FontStyles.Normal;
                else
                    textBlock.FontStyle = FontStyles.Italic;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBlock != null)
            {
                if (textBlock.TextDecorations == TextDecorations.Underline)
                    textBlock.TextDecorations = null;
                else
                    textBlock.TextDecorations = TextDecorations.Underline;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBlock != null)
                textBlock.Foreground = Brushes.Black;
            
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBlock != null)
                textBlock.Foreground = Brushes.Red;
        }
    }
}
