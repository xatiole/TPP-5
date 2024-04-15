using Microsoft.Win32;
using System;
using System.IO;
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

namespace Лабораторная5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveFile()
        {
            SaveFileDialog saveFileDialog = new()
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, Notebook.Text);
            }
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                Notebook.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void ExitFile()
        {
            Application.Current.Shutdown();
        }
        private void PrintFile()
        {
            PrintDialog p = new();
            if (p.ShowDialog() == true)
            {
                p.PrintVisual(Notebook, "Печать");
            }
        }
        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }
        private void MenuPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintFile();
        }
        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            ExitFile();
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void cmbShrift_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string colorName = ((ComboBoxItem)comboBox.SelectedItem).Name;
            FontFamily customFontA = new("Arial");
            FontFamily customFontB = new("Dubai");
            FontFamily customFontC = new("Impact");
            FontFamily customFontD = new("Monotype Corsiva");
            switch (colorName)
            {
                case "Arial":
                    Notebook.FontFamily = customFontA;
                    break;
                case "Dubai":
                    Notebook.FontFamily = customFontB;
                    break;
                case "Impact":
                    Notebook.FontFamily = customFontC;
                    break;
                case "Monotype_Corsiva":
                    Notebook.FontFamily = customFontD;
                    break;
                default:
                    break;
            }

        }

        private void cmbSriftSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string colorName = ((ComboBoxItem)comboBox.SelectedItem).Name;
            switch (colorName)
            {
                case "s12":
                    Notebook.FontSize = 12;
                    break;
                case "s14":
                    Notebook.FontSize = 14;
                    break;
                case "s16":
                    Notebook.FontSize = 16;
                    break;
                case "s18":
                    Notebook.FontSize = 18;
                    break;
                case "s20":
                    Notebook.FontSize = 20;
                    break;
                default:
                    break;
            }
        }
    }
}
