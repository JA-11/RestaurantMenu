using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        public DateTime LastUpdated { get; set; }

        public Menu(List<MenuItem> items, DateTime lastUpdated)
        {
            Items = items;
            LastUpdated = lastUpdated;
        }

        public void AddToMenu(MenuItem item)
        {
            this.Items.Add(item);
        }

        public void RemoveFromMenu(MenuItem item)
        {
            this.Items.Remove(item);
        }

        public void PrintMenu()
        {
            Console.WriteLine("***** GoodFoodInc Menu *****");

            foreach (MenuItem item in Items)
            {
                item.PrintMenuItem();
            }
        }
        
        public void DateTimeUpdate()
        {
            this.LastUpdated = DateTime.Now;
        }
    }
}
