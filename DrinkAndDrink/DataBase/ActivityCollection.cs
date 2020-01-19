using DrinkAndDrink.Class.Activity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.DataBase
{
   public static class ActivityCollection
    {
        public static IMongoCollection<iActivity> userTable = MongoConnection.GetActivityTable();
        public static bool GetDataByID(int id)
        {
            var filter =
                Builders<iActivity>.Filter.Eq(u => u.ID, id);

            return userTable.Find(filter).ToList().Count > 0;
        }
        public static bool NewData(iActivity _act)
        { 
            userTable.InsertOne(_act);
            return true;
        }
    }
}
