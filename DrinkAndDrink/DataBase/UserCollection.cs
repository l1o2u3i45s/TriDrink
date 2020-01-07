using DrinkAndDrink.Class.User;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.DataBase
{
    public static class UserCollection
    {
        public static IMongoCollection<User> userTable = MongoConnection.GetUserTable();
        public static bool Login(User _user) {  
            var filter =
                Builders<User>.Filter.Eq(u => u.Account, _user.Account) & 
                Builders<User>.Filter.Eq(u => u.PassWord, _user.PassWord);

            return userTable.Find(filter).ToList().Count > 0 ;
        }
        public static bool Register(User _user)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Account, _user.Account);

            if (userTable.Find(filter).ToList().Count > 0)
                return false;

            userTable.InsertOne(_user);
            return true;
        }
    }
}
