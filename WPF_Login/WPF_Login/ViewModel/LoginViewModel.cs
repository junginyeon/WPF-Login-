using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if(Id=="a")
                System.Windows.MessageBox.Show("ok");
            
        }
        #endregion
        #endregion
    }
}
