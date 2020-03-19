using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Login.BL
{
    public class PassWordCmd : ICommand
    {
        public static string Password { get; set; }
        #region ICommand Member
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            PasswordBox boxPass = (PasswordBox)parameter;
            Password = boxPass.Password;

            if (Password == "1234")
            {
                System.Windows.MessageBox.Show("Password OK");
            }
            else
            {
                System.Windows.MessageBox.Show("Password No");
            }
        }
        #endregion
    }
}
