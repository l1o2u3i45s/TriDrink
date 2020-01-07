using DrinkAndDrink.Class.Activity;
using DrinkAndDrink.Class.Item;
using DrinkAndDrink.Class.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.Class.Order
{
    public interface iOrder
    {
        iActivity Activity { get; set; }
        User.User OrderUser { get; set; }
        List<iItem> OrderItems { get; set; }
    }
}
