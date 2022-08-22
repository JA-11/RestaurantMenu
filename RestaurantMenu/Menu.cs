using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public DateTime DateTime { get; set; }

        public Menu(List<MenuItem> menuItems, DateTime dateTime)
        {
            MenuItems = menuItems;
            DateTime = dateTime;
        }
    }
}
