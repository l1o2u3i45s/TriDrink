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
            string menupath = @"../../../Class/Shop/Menu";
            foreach (string filepath in Directory.GetFiles(menupath)) {
                var a = JsonConvert.DeserializeObject<DrinkShop>(File.ReadAllText(filepath));
                yield return null;
                //yield return new DrinkShop(JsonConvert.DeserializeObject(File.ReadAllText(filepath)), filepath);
            }
        }
    }
}
