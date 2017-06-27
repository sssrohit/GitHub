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
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Window
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadPage wndw = new LoadPage();
            wndw.Show();
            this.Close();
        }

        private void validateBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wndw = new MainWindow();
            wndw.Show();
            this.Close();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" \b Super Simple Software \n \b Created by Mr. Rohit \n \b Under the guidance of Mr. Prashant Sir");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            SearchPage wndw = new SearchPage();
            wndw.Show();
            this.Close();
        }
    }
}
