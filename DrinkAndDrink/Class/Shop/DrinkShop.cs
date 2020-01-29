using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkAndDrink.Class.Item;
using Newtonsoft.Json;

namespace DrinkAndDrink.Class.Shop
{
    public class DrinkShop : iShop
    {
        public DrinkShop(dynamic shopData,string filepath) {
            ShopKind = (ShopEnum)Enum.Parse((typeof(ShopEnum)), Path.GetFileNameWithoutExtension(filepath));
            Name = shopData.ShopName;
            Phone = shopData.Phone;
            Address = shopData.Address;
            foreach (var _items in shopData.Items)
            {
                    var b = _items.Name;
                    var a = _items.Price;
                    Items.Add(new Drink() { Name = _items.Name, Price = _items.Price });
                
            }
        }
        public ShopEnum ShopKind { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<iItem> Items { get; set; } = new List<iItem>();
    }
}
