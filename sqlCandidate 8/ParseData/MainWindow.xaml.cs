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
using System.Data;
using System.IO;
//using System.Windows.Forms;
using System.ServiceProcess;
using System.Collections;

namespace ParseData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();    

        public MainWindow()
        {
            InitializeComponent();
            //ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            //listname1.ItemsSource = dc.ResumeTable;

            Parser parser = new Parser();
            DataTable dt = new DataTable();
            dt = parser.ParseData();
            listname1.ItemsSource = dt.DefaultView;
        }

        public void abclist()
        {
            ArrayList list = new ArrayList();
            list.Add("summary,Professional Summary");
            list.Add("specialties");
            list.Add("skills,Skills Summary");
            list.Add("experience");
            list.Add("education,Scholastics");
            list.Add("interests");
            list.Add("languages");
            return;
        }

        private void parseBtn_Click(object sender, RoutedEventArgs e)
        {
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //string location = fbd.SelectedPath;
            //string path = openFileDialog1.FileName;
            //string location = openFileDialog1.SelectedPath;
            //if (openFileDialog1.ShowDialog() == DialogResult)
            //{
            //    System.IO.File.Move(path, Properties.Settings.Default.TempResumeFolder);
            //}


            //string sSelectedPath = openFileDialog1.SelectedPath;
            //System.IO.File.Move(path, Properties.Settings.Default.TempInFile);
            //System.IO.File.Move(location, Properties.Settings.Default.TempResumeFolder);


            string FileName = openFileDialog1.FileName;

            
            //foreach (string files in MoveFrom)
            //      {
            //      foreach (string files2 in FileName)
            //{
            //    Directory.Move(MoveFrom, );                                   
            //}
            // }
            string TempResumeFileName = string.Empty;
            TempResumeFileName = Properties.Settings.Default.TempResumeFolder + "\\" + openFileDialog1.SafeFileName;

            if (File.Exists(TempResumeFileName))
            {
                try
                {
                    File.Delete(TempResumeFileName);
                }
                catch (Exception ee)
                { }
            }
            if(FileName==string.Empty)
            {
                MessageBox.Show("Please select file");
            }
            else
            {
                File.Copy(FileName, TempResumeFileName, true);
            }
            
            Parser parser = new Parser();


            DataTable dt = new DataTable();
            dt = parser.ParseData();
            listname1.ItemsSource = dt.DefaultView;
           
            //

            //

        }

        private void selectBtn_Click(object sender, RoutedEventArgs e)
        {


            openFileDialog1.InitialDirectory = @"F:\Rohit";
            openFileDialog1.Title = "Browse PDF Files";

            Nullable<bool> result = openFileDialog1.ShowDialog();
            //if (result == true)
            //{
            // Open document
            string filename = openFileDialog1.FileName;
            selectfileTB.Text = filename;
            //}
        }

        private void multipleBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.Multiselect = true;
            var result = x.FileNames;
            x.ShowDialog();

            foreach (string fileName in x.FileNames)
            {
                selectfileTB.Text = fileName;
            }
        }

        private void exitBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" \b Super Simple Software \n \b Created by Mr. Rohit \n \b Under the guidance of Mr. Prashant Sir");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
