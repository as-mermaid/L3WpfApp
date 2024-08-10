using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
            string fontName = ((sender as ComboBox).SelectedItem as string);
            if (textBlock != null)
                textBlock.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble((sender as ComboBox).SelectedItem);
            if (textBlock != null)
                textBlock.FontSize = fontSize;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock != null)
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                textBlock.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, textBlock.Text);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void themes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             Application.Current.Resources.Clear();
             Uri theme = new Uri(themes.SelectedIndex == 0 ? "Light.xaml" : "Dark.xaml", UriKind.Relative);
             ResourceDictionary themeDictionary = Application.LoadComponent(theme) as ResourceDictionary;   
             Application.Current.Resources.MergedDictionaries.Add(themeDictionary); 
        }
    }
}
