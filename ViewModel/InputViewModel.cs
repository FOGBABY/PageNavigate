using PageNavigate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigate.ViewModel
{
    internal class InputViewModel:ViewModelBase
    {
        public InputViewModel  (TestModel _model):base(_model)
        {

        }

        public Page1ViewModel Page1ViewModel { get; set; }
        public Page2ViewModel Page2ViewModel { get;set; }
    }
}
