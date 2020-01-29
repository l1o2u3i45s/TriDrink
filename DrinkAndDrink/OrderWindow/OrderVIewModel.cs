using DrinkAndDrink.Class;
using DrinkAndDrink.Class.Activity;
using DrinkAndDrink.DataBase;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DrinkAndDrink.OrderWindow
{
   public class OrderVIewModel : ViewModelBase
    {  
        private iActivity activityItem;
        public iActivity ActivityItem
        {
            get { return activityItem; }
            set { Set(() => ActivityItem, ref activityItem, value); }
        }
        private ShopEnum selectedShop;
        public ShopEnum SelectedShop
        {
            get { return selectedShop; }
            set { Set(() => SelectedShop, ref selectedShop, value); }
        }
        private int selectedTime;
        public int SelectedTime
        {
            get { return selectedTime; }
            set { Set(() => SelectedTime, ref selectedTime, value); }
        }
        public List<ShopEnum> ShopCollecttion { get; } = new List<ShopEnum>() { ShopEnum.FiftyLan, ShopEnum.KanChingLong };
        public List<DateTime> TimeCollecttion {
            get { return RealTimeIterator().ToList(); }
        }
        public ICommand UpdateActivityCommand {
            get { return new RelayCommand(() => {
                //LineNotifyBot.GetUserCode();
                ActivityCollection.Update(ActivityItem);
            });
            }
        }
        public OrderVIewModel() {
            
            
        }
        public IEnumerable<DateTime> RealTimeIterator() {
            var time = DateTime.Now.AddHours(1);
            while (true)
            {
                yield return time;
                time = time.AddHours(1);
                if (time.Hour > 18 || DateTime.Now.Hour > 18)
                    break;
            } 
        }
    }
}
