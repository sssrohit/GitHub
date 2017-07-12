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
using System.IO;
using System.Data;
using System.Data.Linq;
//using Aspose.Pdf;

namespace ResumeParse.Views
{
    /// <summary>
    /// Interaction logic for validate.xaml
    /// </summary>
    public partial class validate : Page
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();

        public validate()
        {
            InitializeComponent();

            //ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            //listname1.ItemsSource = dc.ResumeTable;
            //Table<ResumeParse.ResumeTable> disp1 = GetResumeTable();
        }

        //public Table<ResumeParse.ResumeTable> disp3
        //{
        //    get
        //    {
        //        return GetResumeTable();
        //    }
        //}


        public static System.Data.Linq.Table<ResumeTable> GetResumeTable()
        {
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            return dc.GetTable<ResumeTable>();
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
                ViewModel.MainWindoViewModel parser = new ViewModel.MainWindoViewModel();
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
                String experience = dt.Rows[0]["Experience"].ToString();
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
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            selectfileTB.Text = filename;
        }

        private void multipleBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
