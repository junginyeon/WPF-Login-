﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;

namespace WPF_Login
{
    public class PassWordCmd : ICommand
    {
        public string Password { get; set; }
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