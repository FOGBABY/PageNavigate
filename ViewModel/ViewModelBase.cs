using PageNavigate.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PageNavigate.ViewModel
{
    internal class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase(TestModel _model)
        {
            Model = _model;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        protected readonly TestModel Model;
    }
}
