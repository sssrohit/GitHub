using Microsoft.Win32;
using ResumeMVVMLight.ResumeParser;
using System;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace ResumeMVVMLight.View
{
    /// <summary>
    /// Interaction logic for UCNewResumes.xaml
    /// </summary>
    public partial class UCNewResumes : UserControl
    {
        public static Table<ResumeTable> GetResumeTable()
        {
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            return dc.GetTable<ResumeTable>();
        }

        public UCNewResumes()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"F:\Rohit";
            openFileDialog1.Title = "Browse PDF Files";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
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
                ResumeParse parser = new ResumeParse();
                DataTable dt = new DataTable();
                dt = parser.ParseData();
                string name = dt.Rows[0]["Name"].ToString();
                String email = dt.Rows[0]["Email"].ToString();
                String phone = dt.Rows[0]["Phone"].ToString();
                String summary = dt.Rows[0]["Summary"].ToString();
                String skills = dt.Rows[0]["Skills"].ToString();
                String experience = dt.Rows[0]["Experience"].ToString();
                String education = dt.Rows[0]["Education"].ToString();

                InsertOrUpdateEmp(name, email, phone, summary, skills, experience, education);
            }
        }

       

        public static void InsertOrUpdateEmp(string name, string email, string phone, string summary, string skills, string experience, string education)
        {
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
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
        }
    }
}

