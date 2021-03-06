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
using Microsoft.Win32;
using System.Data;
using System.IO;
//using System.Windows.Forms;
using System.ServiceProcess;
using System.Collections;
using System.Data.Linq;
using ParseData.View;

namespace ParseData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public static System.Data.Linq.Table<ResumeTable> GetResumeTable()
        {
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            return dc.GetTable<ResumeTable>();
        }

        public MainWindow()
        {
            InitializeComponent();
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);

            listname1.ItemsSource = dc.ResumeTable;

            //Parser parser = new Parser();
            //DataTable dt = new DataTable();

            //listname1.ItemsSource = dt.DefaultView;
        }

        private void parseBtn_Click(object sender, RoutedEventArgs e)
        {
            string FileName = openFileDialog1.FileName;
            string TempResumeFileName = string.Empty;
            TempResumeFileName = Properties.Settings.Default.TempResumeFolder + "\\" + openFileDialog1.SafeFileName;

            if (File.Exists(TempResumeFileName))
            {
                try
                {
                    File.Delete(TempResumeFileName);
                }
                catch (Exception)
                {
                }
            }
            if (FileName == string.Empty)
            {
                MessageBox.Show("Please select file");

            }
            else
            {
                File.Copy(FileName, TempResumeFileName, true);
                Parser parser = new Parser();
                DataTable dt = new DataTable();
                dt = parser.ParseData();
                listname1.ItemsSource = dt.DefaultView;
                //File.Delete(Properties.Settings.Default.TempResumeFolder);
                //File.Create(Properties.Settings.Default.TempResumeFolder);
                //for (int i = 0; i <= dt.Rows.Count;i++ )
                //{
                    //insert datatable into database
                    string name = dt.Rows[0]["Name"].ToString();
                    String email = dt.Rows[0]["Email"].ToString();
                    String phone = dt.Rows[0]["Phone"].ToString();
                    String summary = dt.Rows[0]["Summary"].ToString();
                    String skills = dt.Rows[0]["Skills"].ToString();
                    String experience =dt.Rows[0]["Experience"].ToString();
                    String education = dt.Rows[0]["Education"].ToString();

                    InsertOrUpdateEmp(name, email, phone, summary, skills, experience, education);
                    System.Data.Linq.Table<ResumeTable> emp = GetResumeTable();
                    listname1.ItemsSource = emp;
                //}
            }
        }

        public static void InsertOrUpdateEmp(string name, string email, string phone, string summary, string skills, string experience, string education)
        {
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            //try
            //{
            Table<ResumeTable> resume = GetResumeTable();
            ResumeTable table = new ResumeTable();

            table.Name = name;
            table.Email = email;
            table.Phone = phone;
            table.Summary = summary;
            table.Skills = skills;
            table.Experience = experience;
            table.Education = education;

            resume.InsertOnSubmit(table);
            resume.Context.SubmitChanges();
            //}
            //catch (Exception)
            //{
            //}
        }

        private void selectBtn_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"F:\Rohit";
            openFileDialog1.Title = "Browse PDF Files";

            string filename = openFileDialog1.FileName;
            selectfileTB.Text = filename;
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
            MessageBox.Show("\b Super Simple Software \n \b Created by Mr. Rohit \n \b Under the guidance of Mr. Prashant Sir");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            //Table<ResumeTable> resume = GetResumeTable();
            //ResumeTable table = new ResumeTable();
            //table.Name = listname1.Name;
            //table.Email = "";
            //resume.InsertOnSubmit(table);
            //resume.Context.SubmitChanges();

            Parser parser = new Parser();
            DataTable dt = new DataTable();
            dt = parser.ParseData();

            //String name = listname1.SelectedItems[0].ToString();
            //String email = listname1.SelectedItems[1].ToString();
            //String phone = listname1.SelectedItems[2].ToString();
            //String summary = listname1.SelectedItems[3].ToString();
            //String skills = listname1.SelectedItems[4].ToString();
            //String experience = listname1.SelectedItems[5].ToString();
            //String education = listname1.SelectedItems[6].ToString();

            string name = dt.Rows[0]["Name"].ToString();
            String email = dt.Rows[0]["Email"].ToString();
            String phone = dt.Rows[0]["Phone"].ToString();
            String summary = dt.Rows[0]["Summary"].ToString();
            String skills = dt.Rows[0]["Skills"].ToString();
            String experience = dt.Rows[0]["Experience"].ToString();
            String education = dt.Rows[0]["Education"].ToString();

            InsertOrUpdateEmp(name, email, phone, summary, skills, experience, education);
            //InsertOrUpdateEmp(name);
            System.Data.Linq.Table<ResumeTable> emp = GetResumeTable();
            listname1.ItemsSource = emp;
        }

        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {
            StartPage wndw = new StartPage();
            wndw.Show();
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            StartPage wndw = new StartPage();
            wndw.Show();
            this.Close();
        }

       
    }
}