using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.Class.Item
{
    public class Drink : iItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public List<Topping> Toppings { get; set; } = new List<Topping>();
    }
    public class Topping :iItem{
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
