using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkAndDrink.Class.Order;
using DrinkAndDrink.Class.Shop;
using DrinkAndDrink.Class.User;

namespace DrinkAndDrink.Class.Activity
{
    public class DrinkActivity : iActivity
    {
        public int ID { get; set; }
        public iShop Shop { get; set; }
        public User.User Creator { get; set; }
        public DateTime CreatTime { get; set; }
        public DateTime DueTime { get; set; }
        public List<iOrder> orders { get; set; }
        
    }
}
