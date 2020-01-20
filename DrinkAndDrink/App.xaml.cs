﻿using DrinkAndDrink.Properties;
using DrinkAndDrink.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;
using System.Windows;

namespace DrinkAndDrink
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        ViewModelLocator locator = new ViewModelLocator(); 
    }
}
