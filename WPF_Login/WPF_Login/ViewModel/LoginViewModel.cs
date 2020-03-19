using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Login.BL;
using WPF_Login.View;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.ComponentModel;

namespace WPF_Login.ViewModel
{
    class LoginViewModel: INotifyPropertyChanged
    {
        public string Id { get; set; }
        public string Pwd { get; set; }
        public Command pswCmd { get; set; }
        public PassWordCmd psw { get; set; }

        public LoginViewModel(PassWordCmd a)
        {
            pswCmd = new Command(executeLogin, canexecuteLogin);
        }
        private void executeLogin(object obj)
        {
            psw = new PassWordCmd();
            if (psw.ToString() == "1234")
            {
                System.Windows.MessageBox.Show("ok");
            }
        }
        private bool canexecuteLogin(object arg)
        {
            return true;
        }
        private ICommand passWordCmd;

        public ICommand PassWordCmd
        {
            get { return passWordCmd; }
            set { passWordCmd = value; }
        }
        #region INotifyPropertyChanged Member

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region INotifyPropertyChanged Methods

        private void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
