using GalaSoft.MvvmLight;
using MongoDB.Bson.Serialization.Attributes;

namespace DrinkAndDrink.Class.User
{
    [BsonIgnoreExtraElements]
    public class User : ObservableObject
    {
        public User(){}
        private string account;
        public string Account
        {
            get => account;
            set => Set(()=>Account, ref account, value);
        }

        private string passWord;
        public string PassWord
        {
            get => passWord; 
            set => Set(()=>PassWord, ref passWord, value);
        }

        private string name;
        public string Name
        {
            get => name; 
            set => Set(()=>Name, ref name, value);
        }
    }
}
