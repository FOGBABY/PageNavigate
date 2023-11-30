﻿using PageNavigate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigate.ViewModel
{
    internal class Page1ViewModel:ViewModelBase
    {
        public Page1ViewModel(TestModel _model):base(_model)
        {
            Model = _model;
        }

        protected readonly TestModel Model;

        public string Name
        { 
            get { return Model.Name; } 
            set {
                Model.Name = value;
                OnPropertyChanged(); 
            } 
        }
    }
}
