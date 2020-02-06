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
        public ShopEnum ShopKind { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<iItem> Items { get; set; } = new List<iItem>();
    }
}
