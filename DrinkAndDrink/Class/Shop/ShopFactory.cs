using DrinkAndDrink.Class.Item;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace DrinkAndDrink.Class.Shop
{
    public static class ShopFactory
    {
        public static IEnumerable<iShop> GetAllDrinkShopData() {

            yield return GetKanChingLongShopData();
        }
        public static DrinkShop GetKanChingLongShopData() {
            DrinkShop shop = new DrinkShop() {ShopKind = ShopEnum.KanChingLong,Name="康青龍", Phone="5555",Address="55" };
            shop.Items.Add(new Drink() { Name="珍珠奶茶",Price=50 });
            return shop;
        }
    }
}
