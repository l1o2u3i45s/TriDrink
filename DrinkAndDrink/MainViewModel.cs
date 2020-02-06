using CommonServiceLocator;
using DrinkAndDrink.Class.Activity;
using DrinkAndDrink.Class.Shop;
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
        public List<iActivity> ActivityCollection
        {
            get { return ActivityFactory.GetAllActivity(); }
        }  
        public List<iShop> ShopCollection
        {
            get { return ShopFactory.GetAllDrinkShopData().ToList(); } 
        }
        private iActivity currentActivity;
        public iActivity CurrentActivity
        {
            get { return currentActivity; }
            set { Set(() => CurrentActivity, ref currentActivity, value); }
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
            DrinkAndDrink.DataBase.ActivityCollection.Init();
        }
        private void InitData() {
            
        }
    }
}
