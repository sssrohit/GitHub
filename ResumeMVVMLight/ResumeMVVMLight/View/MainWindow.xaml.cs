using System.Windows;
using ResumeMVVMLight.ViewModel;

namespace ResumeMVVMLight.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        public static System.Data.Linq.Table<ResumeTable> GetResumeTable()
        {
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            return dc.GetTable<ResumeTable>();
        }

        private void parseBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void selectBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void multipleBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Main_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            //Main.Content = new UCNewResumes();
            //            this.DataContext = ViewModel.ViewModelLocator.ValidateViewmodel;
            ///this.DataContext = ViewModelLocator.Getnewresumes;
        }
    }
}