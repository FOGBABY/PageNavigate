using PageNavigate.Model;
using PageNavigate.View;
using PageNavigate.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PageNavigate
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            TestModel _model = new TestModel();
            MainViewModel _vm = new MainViewModel(_model);
            _vm.Navigate = new NavigateViewModel(_model);
            _vm.Navigate.Page1 = new Page1ViewModel(_model);
            _vm.Navigate.Page2 = new Page2ViewModel(_model);
            _vm.Navigate.Page3 = new Page3ViewModel(_model);

            MainWindow _main = new MainWindow();
            _main.DataContext = _vm;
            _main.Show();
        }
    }
}
