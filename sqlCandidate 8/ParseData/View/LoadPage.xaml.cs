using System;
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
using System.Windows.Shapes;
using Microsoft.Win32;

namespace ParseData.View
{
    /// <summary>
    /// Interaction logic for LoadPage.xaml
    /// </summary>
    public partial class LoadPage : Window
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public LoadPage()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            StartPage wndw = new StartPage();
            wndw.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" \b Super Simple Software \n \b Created by Mr. Rohit \n \b Under the guidance of Mr. Prashant Sir");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"F:\Rohit";
            openFileDialog1.Title = "Browse PDF Files";

            string filename = openFileDialog1.FileName;
            selectfileTB.Text = filename;
        }

        
    }
}
