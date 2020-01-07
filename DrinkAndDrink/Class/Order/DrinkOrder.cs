using DrinkAndDrink.Class.Activity;
using DrinkAndDrink.Class.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.Class.Order
{
    public class DrinkOrder :iOrder
    {
       public iActivity Activity { get; set; }
       public User.User OrderUser { get; set; }
       public List<iItem> OrderItems { get; set; }
    }
}
