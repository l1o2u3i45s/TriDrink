using CommonServiceLocator;
using DrinkAndDrink.Class.User;
using DrinkAndDrink.DataBase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Google.Cloud.Firestore;

namespace DrinkAndDrink
{
    /// <summary>
    /// LoginWindow.xaml 的互動邏輯
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        } 
        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            //User loginUser = new User() {Account= txtAccountLogin.Text,PassWord = txtPasswordLogin.Text };
            //if (UserCollection.Login(loginUser)) {
            //    Hide(); 
            //    ServiceLocator.Current.GetInstance<MainViewModel>().CurrentUser = loginUser;
            //    new MainWindow() { Owner = this }.Show();
            //} 
            //else
            //    MessageBox.Show("登入失敗~");
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            //var loginUser = new User { Account = txtAccountRegister.Text, PassWord = txtPasswordRegister.Text };
            //if (UserCollection.Register(loginUser))
            //{
            //    Hide();
            //    ServiceLocator.Current.GetInstance<MainViewModel>().CurrentUser = loginUser;
            //    new MainWindow() { Owner = this }.Show();
            //}
            //else
            //    MessageBox.Show("註冊失敗~已經辦過帳號惹~");
        }
    }
}
