using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Login.BL;
using WPF_Login.View;
using System.Windows;

namespace WPF_Login.ViewModel
{
    class LoginViewModel
    {
        public string Id { get; set; }
        public string Pwd { get; set; }
        public Command LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(executeLogin, canexecuteLogin);
        }
        private void executeLogin(object obj)
        {
            if(Id=="root" && Pwd == "1234")
            {
                Login page = new Login();
                page.ShowDialog();
            }
        }
        private bool canexecuteLogin(object arg)
        {
            return true;
        }
    }
}
