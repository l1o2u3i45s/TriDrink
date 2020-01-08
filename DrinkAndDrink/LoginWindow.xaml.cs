using DrinkAndDrink.Class.User;
using DrinkAndDrink.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
            User loginUser = new User() {Account= txtAccount.Text,PassWord = txtPassword.Text };
            if (UserCollection.Login(loginUser)) {
                Hide();
                new MainWindow(loginUser).Show(); 
            } 
            else
                MessageBox.Show("登入失敗~");
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            User loginUser = new User() { Account = txtAccount.Text, PassWord = txtPassword.Text };
            if (UserCollection.Register(loginUser))
            {
                Hide();
                new MainWindow(loginUser).Show();
            }
            else
                MessageBox.Show("註冊失敗~已經辦過帳號惹~");
        }
    }
}
