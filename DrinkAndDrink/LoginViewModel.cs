using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommonServiceLocator;
using DrinkAndDrink.Class.User;
using DrinkAndDrink.DataBase;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace DrinkAndDrink
{
    public class LoginViewModel : ViewModelBase
    {
        public List<object> IsInvalidElements = new List<object>();
        private bool loginSuccess;
        public bool LoginSuccess
        {
            get => loginSuccess;
            set => Set(() => LoginSuccess, ref loginSuccess, value);
        }
        private bool canRegisterOrLogin => IsInvalidElements != null && IsInvalidElements.Count == 0;
        public User CurrentUser { get; set; }
        public RelayCommand Register { get; set; }
        public RelayCommand Login { get; set; }
        public LoginViewModel()
        {
            CurrentUser = new User();
            InitCommands();
        }

        private void InitCommands()
        {
            Register = new RelayCommand(RegisterAction,() => canRegisterOrLogin);
            Login = new RelayCommand(LoginAction,() => canRegisterOrLogin);
        }

        private void RegisterAction()
        {
            if (UserDB.Register(CurrentUser))
            {
                LoginSuccess = true;
                ServiceLocator.Current.GetInstance<MainViewModel>().CurrentUser = CurrentUser;
            }
            else
            {
                MessageBox.Show("註冊失敗~已經辦過帳號惹~");
                LoginSuccess = false;
            }
        }
        private void LoginAction()
        {
            if (UserDB.Login(CurrentUser))
            {
                LoginSuccess = true;
                ServiceLocator.Current.GetInstance<MainViewModel>().CurrentUser = CurrentUser;
            }
            else
            {
                MessageBox.Show("登入失敗~");
                LoginSuccess = false;
            }
        }
    }
}
