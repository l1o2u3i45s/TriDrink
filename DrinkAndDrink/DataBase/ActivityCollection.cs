using DrinkAndDrink.Class.Activity;
using MongoDB.Bson.Serialization;
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
        public static void Init() {
            BsonClassMap.RegisterClassMap<DrinkActivity>(cm =>
            { 
                cm.SetIgnoreExtraElements(true);
                cm.AutoMap(); 
            });
        }
        public static bool GetDataByID(int id)
        {
            var filter =
                Builders<iActivity>.Filter.Eq(u => u.ID, id);

            return userTable.Find(filter).ToList().Count > 0;
        }
        public static List<iActivity> GetAllData() {
            var a = userTable.Find(_ =>   _.ID == 0).ToList();
            return userTable.Find(_ => true).ToList(); 
        }
        public static int GetLastID()
        {
            var list =   userTable.Aggregate().SortByDescending((a) => a.Creator).FirstAsync();
            return 0;
        }
        
        public static void Update(iActivity _act)
        {
           
            if (_act.ID == 0)
            {
                // var table = userTable.sort(_id: -1).limit(1).pretty();
                userTable.InsertOne(_act);
            }
            else {
               // userTable.UpdateOne(_act);
            }
                
        }
    }
}
