using PageNavigate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigate.ViewModel
{
    internal class MainViewModel:ViewModelBase
    {
        public MainViewModel(TestModel _model):base(_model)
        {

        }

        public NavigateViewModel Navigate { get; set; }

        public InputViewModel Input { get; set; }
    }
}
