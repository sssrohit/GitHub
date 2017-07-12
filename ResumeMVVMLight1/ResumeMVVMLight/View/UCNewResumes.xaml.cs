using Microsoft.Win32;
using ResumeMVVMLight.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
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

namespace ResumeMVVMLight.View
{
    /// <summary>
    /// Interaction logic for UCNewResumes.xaml
    /// </summary>
    public partial class UCNewResumes : UserControl
    {
        public static System.Data.Linq.Table<ResumeTable> GetResumeTable()
        {
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            return dc.GetTable<ResumeTable>();
        }

        public UCNewResumes()
        {
            InitializeComponent();
            //UCResume uc = new UCResume();
            //Grid.SetRow(uc, 1);
            //myGrid.Children.Add(uc);
            //this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = @"F:\Rohit";
            openFileDialog1.Title = "Browse PDF Files";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            //selectfileTB.Text = filename;
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
                
                // listname1.ItemsSource = emp;
                //}

                //Application.Current.Dispatcher.Invoke(delegate {
                //    // update UI
                //});

                //Application.Current.Dispatcher.Invoke(new Action(() =>
                //{ /* Your code here */
                    File.Copy(FileName, TempResumeFileName, true);
                    MainWindowViewModel parser = new MainWindowViewModel();
                    DataTable dt = new DataTable();
                    dt = parser.ParseData();
                    //listname1.ItemsSource = dt.DefaultView;
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
                    Table<ResumeTable> emp = GetResumeTable();
                //}));
                itemcontrol.Items.Refresh();
            }
        }

        public static void InsertOrUpdateEmp(string name, string email, string phone, string summary, string skills, string experience, string education)
        {
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            //try
            //{
            Table<ResumeTable> resume = GetResumeTable();
            ResumeTable table = new ResumeTable()
            {
                Name = name,
                Email = email,
                Phone = phone,
                Summary = summary,
                Skills = skills,
                Experience = experience,
                Education = education
            };
            resume.InsertOnSubmit(table);
            resume.Context.SubmitChanges();
            //}
            //catch (Exception)
            //{
            //}
        }

    }
}

