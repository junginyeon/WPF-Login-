using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_Login.BL;
using WPF_Login.View;

namespace WPF_Login.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {
        public static string Id { get; set; }
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
            if (Id == "root")
            {
                if (Password == "1234")
                {
                    System.Windows.MessageBox.Show("로그인 성공");
                    Login page = new Login();
                    page.ShowDialog();
                }
                else
                {
                    System.Windows.MessageBox.Show("비밀번호 오류");
                }
            }
            else
            {
                if (Password == "1234")
                {
                    System.Windows.MessageBox.Show("아이디 오류");
                }
                else
                {
                    System.Windows.MessageBox.Show("존재하지 않는 사용자입니다.");
                }
            }
        }
        #endregion
                   
        #endregion
    }
}
