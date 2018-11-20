using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool IsLoaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand UnitCommand { get; set; }
        public ICommand SuplierCommand { get; set; }
        public ICommand CustomerCommand { get; set; }
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; },(p) => {
                IsLoaded = true;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
            });

            //MessageBox.Show("Đã vào trong MainViewModel -> DataContext của mainwindow.xaml");
            UnitCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                UnitWindow wd = new UnitWindow();
                wd.ShowDialog();
            });
            //
            SuplierCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SuplierWindow wd = new SuplierWindow();
                wd.ShowDialog();
            });
            //
            CustomerCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                CustomerWindow wd = new CustomerWindow();
                wd.ShowDialog();
            });
            //
        }
    }
}
