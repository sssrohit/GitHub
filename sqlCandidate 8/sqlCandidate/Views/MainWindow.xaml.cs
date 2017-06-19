using sqlCandidate.Models;
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

namespace sqlCandidate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CandidateDbaseContext dc = new CandidateDbaseContext(Properties.Settings.Default.DatabasePath);
            listname.ItemsSource = dc.CandidateTable;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Accessor.InsertOrUpdateEmp(dateTB.Text,nameTB.Text,positionTB.Text,worklocationTB.Text,currentlocationTB.Text,contactnoTB.Text,emailTB.Text,qualificationTB.Text,topexpTB.Text,relevantexpTB.Text,currentcompanyTB.Text,currentctcTB.Text,expectedctcTB.Text,noticeperiodTB.Text);

                dateTB.Text = null;
                nameTB.Text = null;
                positionTB.Text = null;
                worklocationTB.Text = null;
                currentlocationTB.Text = null;
                contactnoTB.Text = null;
                emailTB.Text = null;
                qualificationTB.Text = null;
                topexpTB.Text = null;
                relevantexpTB.Text = null;
                currentcompanyTB.Text = null;
                currentctcTB.Text = null;
                expectedctcTB.Text = null;
                noticeperiodTB.Text = null;

                System.Data.Linq.Table<CandidateTable> emp = Accessor.GetEmployeeTable();
                listname.ItemsSource = emp;
                MessageBox.Show("Record Inserted..............");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Accessor.DeleteEmp(nameTB.Text);

                dateTB.Text = null;
                nameTB.Text = null;
                positionTB.Text = null;
                worklocationTB.Text = null;
                currentlocationTB.Text = null;
                contactnoTB.Text = null;
                emailTB.Text = null;
                qualificationTB.Text = null;
                topexpTB.Text = null;
                relevantexpTB.Text = null;
                currentcompanyTB.Text = null;
                currentctcTB.Text = null;
                expectedctcTB.Text = null;
                noticeperiodTB.Text = null;

                System.Data.Linq.Table<CandidateTable> emp = Accessor.GetEmployeeTable();
                listname.ItemsSource = emp;
                MessageBox.Show("Record Deleted...........");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            dateTB.Text = null;
            nameTB.Text = null;
            positionTB.Text = null;
            worklocationTB.Text = null;
            currentlocationTB.Text = null;
            contactnoTB.Text = null;
            emailTB.Text = null;
            qualificationTB.Text = null;
            topexpTB.Text = null;
            relevantexpTB.Text = null;
            currentcompanyTB.Text = null;
            currentctcTB.Text = null;
            expectedctcTB.Text = null;
            noticeperiodTB.Text = null;
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Accessor.UpdateEmp(dateTB.Text, nameTB.Text, positionTB.Text, worklocationTB.Text, currentlocationTB.Text, contactnoTB.Text, emailTB.Text, qualificationTB.Text, topexpTB.Text, relevantexpTB.Text, currentcompanyTB.Text, currentctcTB.Text, expectedctcTB.Text, noticeperiodTB.Text);

                dateTB.Text = null;
                nameTB.Text = null;
                positionTB.Text = null;
                worklocationTB.Text = null;
                currentlocationTB.Text = null;
                contactnoTB.Text = null;
                emailTB.Text = null;
                qualificationTB.Text = null;
                topexpTB.Text = null;
                relevantexpTB.Text = null;
                currentcompanyTB.Text = null;
                currentctcTB.Text = null;
                expectedctcTB.Text = null;
                noticeperiodTB.Text = null;

                System.Data.Linq.Table<CandidateTable> emp = Accessor.GetEmployeeTable();
                listname.ItemsSource = emp;
                MessageBox.Show("Record Updated...........");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" \b Super Simple Software \n \b Created by Mr. Rohit \n \b Under the guidance of Mr. Prashant Sir");
        }



    }
}
