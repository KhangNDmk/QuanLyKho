using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyKho.ViewModel
{
    public class ControlBarViewModel : BaseViewModel
    {
        #region commands
        public ICommand CloseWindowCommand { get; set; }
        #endregion

        public ControlBarViewModel()
        {
            CloseWindowCommand = new RelayCommand<UserControl>( (p)=> { return true; }, (p)=> { } );
        }
    }
}
