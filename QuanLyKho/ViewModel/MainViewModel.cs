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
        public MainViewModel()
        {
            IsLoaded = true;
            LoadedWindowCommand = new RelayCommand<object>((p) => { return true; },(p) => {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();
            });

            //MessageBox.Show("Đã vào trong MainViewModel -> DataContext của mainwindow.xaml");
        }
    }
}
