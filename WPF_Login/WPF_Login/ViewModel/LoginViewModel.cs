using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Login.BL;
using WPF_Login.View;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Login.ViewModel
{
    class LoginViewModel
    {
        public string LoginID { get; set; }
        public string LoginPWD { get; set; }
        public Command LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(executeLogin, canexecuteLogin);
        }
        private void executeLogin(object obj)
        {
            
        }
        private bool canexecuteLogin(object arg)
        {
            return true;
        }
    }
}
