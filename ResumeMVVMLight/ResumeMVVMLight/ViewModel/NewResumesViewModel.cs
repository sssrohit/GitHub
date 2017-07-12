using GalaSoft.MvvmLight;
using ResumeMVVMLight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeMVVMLight.ViewModel
{
    public class NewResumesViewModel : ViewModelBase
    {
      

        public List<Resume> AllNewResumes
        {
            get
            {
                return Model.MainModel.GetAllResumes();
            }
        }

        public List<Resume> NewResumes
        {
            get
            {
                return Model.MainModel.GetAllResumes();
            }
        }

        public void RaiseAllPropertyChange()
        {
            this.RaisePropertyChanged("AllNewResumes");
        }
    }
}
