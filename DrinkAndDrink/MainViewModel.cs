using CommonServiceLocator;
using DrinkAndDrink.Class.Activity;
using DrinkAndDrink.Class.User;
using DrinkAndDrink.DataBase;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<iActivity> activityCollection;
        public ObservableCollection<iActivity> ActivityCollection  
        {
            get { return activityCollection; }
            set { Set(() => ActivityCollection, ref activityCollection, value); }
        }
        public ICommand OpenOrderWindowCommand
        {
            get
            {
                return new RelayCommand<string>((id) =>
                {
                    ServiceLocator.Current.GetInstance<OrderWindow.OrderVIewModel>().ActivityItem = ActivityFactory.DrinkFactory(id); 
                    OrderWindow.OrderWindow orderWindow = new OrderWindow.OrderWindow();
                    orderWindow.ShowDialog();
                });
            }
        }
        public MainViewModel( )  {
             
        }
        private void InitData() {
            
        }
    }
}
