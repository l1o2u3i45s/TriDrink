using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.Class.User
{
    [BsonIgnoreExtraElements]
    public class User
    {
        public string Account { get; set; }
        public string PassWord { get; set; } 
    }
}
