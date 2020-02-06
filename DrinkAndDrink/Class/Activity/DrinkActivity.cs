using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;
using DrinkAndDrink.Class.Order;
using DrinkAndDrink.Class.Shop;
using DrinkAndDrink.Class.User;
using MongoDB.Bson.Serialization.Attributes;

namespace DrinkAndDrink.Class.Activity
{ 
    public class DrinkActivity : iActivity
    {
        public int ID { get; set; }
        public DrinkShop Shop { get; set; }
        public User.User Creator { get; set; } = ServiceLocator.Current.GetInstance<MainViewModel>().CurrentUser;
        public DateTime CreatTime { get; set; } = DateTime.Now;
        public DateTime DueTime { get; set; }
        public List<iOrder> orders { get; set; } 
        
    }
}
