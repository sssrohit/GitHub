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
using Microsoft.Win32;
//using System.Windows.Forms;
using System.Windows;

namespace ParseData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResumeDBContext dc = new ResumeDBContext(Properties.Settings.Default.ResumeDBpath);
            listname1.ItemsSource = dc.ResumeTable;
        }

       

        private void parseBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void selectBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"F:\Rohit";
            openFileDialog1.Title = "Browse PDF Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            //openFileDialog1.DefaultExt = "txt";
            //openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //if (openFileDialog1.ShowDialog() == DialogResult)
            //{
            //    selectfileTB.Text = openFileDialog1.FileName;
            //}

            Nullable<bool> result = openFileDialog1.ShowDialog();
            if (result == true)
            {
                // Open document
                string filename = openFileDialog1.FileName;
                selectfileTB.Text = filename;
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" \b Super Simple Software \n \b Created by Mr. Rohit \n \b Under the guidance of Mr. Prashant Sir");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void multipleBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Multiselect = true;
           // x.ShowDialog();
            string[] result = x.FileNames;

            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            //Nullable<bool> result1 = openFileDialog1.ShowDialog();
            Nullable<bool> result1 = x.ShowDialog();
            if (result1 == true)
            {
                // Open document

                string filename = x.FileName;
                selectfileTB.Text = filename;
            }

            //foreach (string y in result)
            //    MessageBox.Show(y, "Selected Item");
            //, MessageBoxButtons.OK, MessageBoxIcon.Information
        }
    }
}
