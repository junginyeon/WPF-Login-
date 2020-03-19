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
            if(Pwd.to="1")
                System.Windows.MessageBox.Show("ok");
            
        }
        #endregion
        #region ICommand Member
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            PasswordBox boxPass = (PasswordBox)parameter;
            Pwd = boxPass.Password;          
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
