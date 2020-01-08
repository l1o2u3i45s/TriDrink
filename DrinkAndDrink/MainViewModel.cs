using DrinkAndDrink.Class.User;
using DrinkAndDrink.DataBase;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DrinkAndDrink
{
    public class MainViewModel:ViewModelBase
    {
        
        private User currentUser;
        public User CurrentUser {
            get { return currentUser; }
            set { Set(() => CurrentUser, ref currentUser, value); }
        }
        public MainViewModel( )  { 
        } 
    }
}
