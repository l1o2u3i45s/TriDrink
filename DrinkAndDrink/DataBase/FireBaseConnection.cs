using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using Newtonsoft.Json.Linq;

namespace DrinkAndDrink.DataBase
{
    public static class FireBaseConnection
    {
        private static readonly FirebaseConfig Config = GetConfig();

        private static FirebaseConfig GetConfig()
        {
            return new FirebaseConfig
            {
                AuthSecret = "x405cqXj1AXc2sZglEi6JTPNZwb8iMupkYOPRWFm",
                BasePath = "https://tridrinksdb.firebaseio.com/"
            };
        }
 
        public static FirebaseClient GetClient()
        {
            if (Config != null)
                return new FirebaseClient(Config);
            throw new Exception("NullException : FirebaseClient is null.");
        }
    }
}
