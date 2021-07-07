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

namespace Notepad
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

        private void toglebtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
        public string flname { get; set; }
        private void openbtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            if (openFileDlg.ShowDialog() == true)
            {
                using (StringReader reader = new StringReader(openFileDlg.FileName))
                {
                    filetxtbox.Text = reader.ReadToEnd();
                    flname = openFileDlg.FileName;
                    NoteTxtBox.Text = File.ReadAllText(filetxtbox.Text);
                }
            }
        }

        private void Cutbtn_Click(object sender, RoutedEventArgs e)
        {
            NoteTxtBox.Cut();
        }

        private void Copybtn_Click(object sender, RoutedEventArgs e)
        {
            NoteTxtBox.Copy();
        }

        private void PasteBtn_Click(object sender, RoutedEventArgs e)
        {
            NoteTxtBox.Paste();
        }

        private void SelectAllBtn_Click(object sender, RoutedEventArgs e)
        {
            NoteTxtBox.SelectAll();
            NoteTxtBox.Focus();
        }

        private void XBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            using (StreamWriter streamWriter = new StreamWriter(flname))
            {
                streamWriter.Write(NoteTxtBox.Text);
            }
        }

        private void NoteTxtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (toglebtn.pressed == true)
            {
                SaveFileDialog save = new SaveFileDialog();

                using (StreamWriter streamWriter = new StreamWriter(flname))
                {
                    streamWriter.Write(NoteTxtBox.Text);
                }
            }
        }
    }
}
