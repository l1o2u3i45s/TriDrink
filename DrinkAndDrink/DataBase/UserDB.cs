using System;
using DrinkAndDrink.Class.User;
using FireSharp.Interfaces;

namespace DrinkAndDrink.DataBase
{
    public static class UserDB
    {

        private static IFirebaseClient client = FireBaseConnection.GetClient();

        public static bool Login(User user) {  
            var userFromDb =client.Get(@"Users/" + user.Account).ResultAs<User>();
            return userFromDb != null && userFromDb.PassWord.Equals(user.PassWord);
        }

        public static bool Register(User user)
        {
            if (CheckExist(user.Account))
                return false;
            try
            {
                client.Set(@"Users/"+user.Account,user);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        private static bool CheckExist(string account)
        {
            var user =client.Get(@"Users/" + account);
            return !string.IsNullOrEmpty(user.Body) && !user.Body.Equals("null");
        }
    }
}
