using DrinkAndDrink.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.Class.Shop
{
    public interface iShop
    {
        ShopEnum ShopKind { get; set; }
        string Name { get; set; }
        string Phone { get; set; } 
        string Address { get; set; }
        List<iItem> Items { get; set; }
    }
}
