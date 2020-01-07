using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAndDrink.Class.Activity
{
    public static class ActivityFactory
    {
        public static DrinkActivity DrinkFactory() {
            return new DrinkActivity();
        }
    }
}
