using CommonServiceLocator;
using DrinkAndDrink.Class.Order;
using DrinkAndDrink.Class.Shop;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.Class.Activity
{
   
    public interface iActivity
    { 
        [BsonId]
        int ID { get; set; } 
        User.User Creator { get; set; } 
        DateTime CreatTime { get; set; }
        DateTime DueTime { get; set; }
        List<iOrder> orders { get; set; }
    }
}
