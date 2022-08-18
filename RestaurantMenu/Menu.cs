using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Goodfood { get; set; }

        public DateTime DateTime { get; set; }

        public Menu(List<MenuItem> goodfood, DateTime dateTime)
        {
            Goodfood = goodfood;
            DateTime = dateTime;
        }

    }
}
