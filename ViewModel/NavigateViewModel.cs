using PageNavigate.Model;
using PageNavigate.View.SubFrame;
using PageNavigate.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PageNavigate.ViewModel
{
    internal class NavigateViewModel:ViewModelBase
    {
        private object _currentPage;
        public object CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set 
            {
                if (_currentPage != value) 
                {
                    _currentPage = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand NavigateCommand { get; set; }
        public ICommand NavigateCommandBack { get; set; }

        public Page1ViewModel Page1 { get; set; }

        public Page2ViewModel Page2 { get; set; }

        public Page3ViewModel Page3 { get; set; }

        public void NavigateToPage1(object parameter) => CurrentPage = Page1;
        public void NavigateToPage2(object parameter)
        {
            if(Model.Name == "G")
                CurrentPage = Page3;
            else
                CurrentPage = Page2;
        }



        public NavigateViewModel(TestModel _model):base(_model)
        {
            NavigateCommand = new ViewModelCommand(NavigateToPage2);
            NavigateCommandBack = new ViewModelCommand(NavigateToPage1);
            CurrentPage = new Page1ViewModel(_model);
        }
    }
}
