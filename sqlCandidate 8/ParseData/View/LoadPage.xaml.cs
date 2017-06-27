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

namespace ParseData.View
{
    /// <summary>
    /// Interaction logic for LoadPage.xaml
    /// </summary>
    public partial class LoadPage : Window
    {
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

        
    }
}
