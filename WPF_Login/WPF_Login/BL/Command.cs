using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Login.BL
{
    class Command : ICommand//명령
    {
        Action<object> _execute;//변수 선언
        Func<object, bool> _canexecute;
        public Command(Action<object> execute, Func<object, bool> canexecute)//생성자
        {
            _execute = execute;//mapping
            _canexecute = canexecute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)//수행가능 여부
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);//수행하면서 넘겨오는 parameter를  넘겨주자..
        }
    }
}
