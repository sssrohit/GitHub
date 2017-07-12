﻿using GalaSoft.MvvmLight;
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
        private readonly IDataService _dataService;


        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        //public MainViewModel(IDataService dataService)
        //{
        //    _dataService = dataService;
        //    _dataService.GetData(
        //        (item, error) =>
        //        {
        //            if (error != null)
        //            {
        //                // Report error here
        //                return;
        //            }

        //            WelcomeTitle = item.Title;
        //        });
        //}

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
            this.RaisePropertyChanged("AllResumes");
        }
    }
        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    
}