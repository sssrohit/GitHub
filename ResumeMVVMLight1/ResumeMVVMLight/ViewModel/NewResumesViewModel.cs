using GalaSoft.MvvmLight;
using System.Collections.Generic;

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
            RaisePropertyChanged("AllNewResumes");
        }
    }
}
