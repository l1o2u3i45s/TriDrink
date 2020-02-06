using DrinkAndDrink.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.Class.Activity
{
    public static class ActivityFactory
    {
        public static List<iActivity> GetAllActivity() {
            return ActivityCollection.GetAllData(); 
        }
        public static DrinkActivity DrinkFactory(string id) {

            return new DrinkActivity();
        }
    }
}
