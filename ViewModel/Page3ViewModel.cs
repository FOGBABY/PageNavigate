using PageNavigate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigate.ViewModel
{
    internal class Page3ViewModel:ViewModelBase
    {
        public Page3ViewModel(TestModel _model) : base(_model)
        {
            Model = _model;
        }

        protected readonly TestModel Model;
    }
}
