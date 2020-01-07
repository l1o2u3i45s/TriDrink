using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.Class.Item
{
   public interface iItem
    {
        string Name { get; set; }
        int Price { get; set; }
    }
}
