using DrinkAndDrink.Class;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.OrderWindow
{
   public class OrderVIewModel : ViewModelBase
    { 
        private string activityID;
        public string ActivityID
        {
            get { return activityID; }
            set { Set(() => ActivityID, ref activityID, value);
                if (!string.IsNullOrEmpty(value)) {
                    //撈Activity資料
                } 
            }
        }
        private ShopEnum selectedShop;
        public ShopEnum SelectedShop
        {
            get { return selectedShop; }
            set { Set(() => SelectedShop, ref selectedShop, value); }
        }
        private ObservableCollection<ShopEnum> shopCollecttion;
        public ObservableCollection<ShopEnum> ShopCollecttion
        {
            get { return shopCollecttion; }
            set { Set(() => ShopCollecttion, ref shopCollecttion, value); }
        }
        private DateTime selectedTime = DateTime.Now.AddHours(2);
        public DateTime SelectedTime
        {
            get { return selectedTime; }
            set { Set(() => SelectedTime, ref selectedTime, value); }
        }
        public OrderVIewModel() {
            ShopCollecttion = new ObservableCollection<ShopEnum>() {ShopEnum.FiftyLan,ShopEnum.KanChingLong };
        }
    }
}
