using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using ResumeMVVMLight.Model;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ResumeMVVMLight.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.mainwindoviewmodel = new NewResumesViewModel();
        }
        NewResumesViewModel mainwindoviewmodel;
         public List<Resume> AllResumes
        {
            get
            {
                return Model.MainModel.GetAllResumes();
            }
        }

        public List<Resume> AllNewResumes
        {
            get
            {
                return Model.MainModel.GetAllResumes();
            }
        }

        internal NewResumesViewModel Newresumes
        {
            get { return mainwindoviewmodel; }

        }

        public void RaiseAllPropertyChange()
        {
            //RaisePropertyChanged("AllResumes");
            RaisePropertyChanged("AllNewResumes");
        }
    }
}