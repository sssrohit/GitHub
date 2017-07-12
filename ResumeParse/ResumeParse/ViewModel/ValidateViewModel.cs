using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResumeParse.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace ResumeParse.ViewModel
{
    class ValidateViewModel : ViewModelBase
    {
        //public static System.Data.Linq.Table<ResumeTable> GetResumeTable()
        //{
        //    ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
        //    return dc.GetTable<ResumeTable>();
        //}

        public List<Resume> AllResumes
        {
            get
            {
                return Model.ValidateModel.GetAllResumes();
            }
        }

        public List<Resume> AllNewResumes
        {
            get
            {
                return Model.ValidateModel.GetAllResumes();
            }
        }

        public void RaiseAllPropertyChange()
        {
            this.RaisePropertyChanged("AllResumes");
        }
    }
}
