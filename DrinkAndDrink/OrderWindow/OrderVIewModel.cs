﻿using DrinkAndDrink.Class;
using DrinkAndDrink.Class.Activity;
using DrinkAndDrink.Class.Shop;
using DrinkAndDrink.DataBase;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DrinkAndDrink.OrderWindow
{
   public class OrderVIewModel : ViewModelBase
    {  
        private DrinkActivity activityItem;
        public DrinkActivity ActivityItem
        {
            get { return activityItem; }
            set { Set(() => ActivityItem, ref activityItem, value); }
        }  
        public List<iShop> ShopCollecttion { get; } = ShopFactory.GetAllDrinkShopData().ToList();
        public List<DateTime> TimeCollecttion {
            get { return RealTimeIterator().ToList(); }
        }
        public ICommand UpdateActivityCommand {
            get { return new RelayCommand(() => {
                //LineNotifyBot.GetUserCode();
                ActivityItem.ID = ActivityItem.ID == 0 ? ActivityCollection.GetLastID() : ActivityItem.ID;
                ActivityCollection.Update(ActivityItem);
            });
            }
        }
        public OrderVIewModel() {
           
        }
        public IEnumerable<DateTime> RealTimeIterator() {
            var time = DateTime.Now.AddHours(1);
            while (true)
            {
                yield return time;
                time = time.AddHours(1);
                if (time.Hour > 18 || DateTime.Now.Hour > 18)
                    break;
            } 
        }
    }
}
