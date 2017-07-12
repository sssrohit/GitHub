using ResumeParse.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ResumeParse
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Main.Content = new Load();
            //dashboard.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main.Content = new validate();
            DataContext = ViewModel.ViewModelLocator.ValidateViewmodel;
            //dashboard.Visibility = Visibility.Hidden;
        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Main.Content = new Search();
            //dashboard.Visibility = Visibility.Hidden;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" \b Resume Parser | Super Simple Software \n \b Created by Mr.Rohit \n \b Under the guidance of Mr.Prashant Sir");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
