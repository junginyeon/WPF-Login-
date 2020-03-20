using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_Login.BL;

namespace WPF_Login.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {
        public static string Id { get; set; }
        public static string Pwd { get; set; }
        public static PassWordCmd pswCmd { get; set; }
        public static string Password { get; set; }

        #region Commands
        #region LoginCommand
        private ICommand loginCommand;

        public ICommand LoginCommand
        {
            get
            {
                return (this.loginCommand) ?? (this.loginCommand = new DelegateCommand(LoginBtn));
            }
        }
        private void LoginBtn()
        {        
            if (Id == "1" && Pwd=="1")
            {
                System.Windows.MessageBox.Show("ok");
            }
        }
        #endregion
        #region
        public void Execute(object parameter)
        {
            PasswordBox boxPass = (PasswordBox)parameter;
            Password = boxPass.Password;
            Pwd = Password;
            /*if (Password == "1234")
            {
                System.Windows.MessageBox.Show("Password OK");
            }
            else
            {
                System.Windows.MessageBox.Show("Password No");
            }*/
        }

        #endregion            
        #endregion
    }
}
