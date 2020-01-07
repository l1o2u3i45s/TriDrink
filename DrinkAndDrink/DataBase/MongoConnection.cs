using DrinkAndDrink.Class;
using DrinkAndDrink.Class.Activity;
using DrinkAndDrink.Class.Order;
using DrinkAndDrink.Class.Shop;
using DrinkAndDrink.Class.User;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.DataBase
{
    public static class MongoConnection
    {
        public static MongoClient _mongoClient = new MongoClient("mongodb+srv://DrinkTable:tridrink@cluster0-qhvy6.gcp.mongodb.net/test?retryWrites=true&w=majority");
        public static IMongoDatabase _mongoDatabase = _mongoClient.GetDatabase("DrinkTable");
        public static void Insert(this IMongoCollection<object> _mongoCollection,object data)
        {
              _mongoCollection.InsertOne(data);
        }
        public static IMongoCollection<iShop> GetShopTable()
        {
            return _mongoDatabase.GetCollection<iShop>("ShopCollection"); 
        }
        public static IMongoCollection<User> GetUserTable()
        {
            return _mongoDatabase.GetCollection<User>("UserCollection");
        }
        public static IMongoCollection<iOrder> GetOrderTable()
        {
            return _mongoDatabase.GetCollection<iOrder>("OrderCollection");
        }
        public static IMongoCollection<iActivity> GetActivityTable()
        {
            return _mongoDatabase.GetCollection<iActivity>("ActivityCollection");
        }

    }
}
