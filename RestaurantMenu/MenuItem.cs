using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; set; }

        public MenuItem(double price, string description, string category, bool isNew)
        {
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public string IsItemNew()
        {
            if (this.IsNew)
            {
                return "---Brand new item!---";
            }
            else
            {
                return "---Traditional option---";
            }
        }

        public void PrintMenuItem()
        {
            Console.WriteLine($"{this.Description} ${this.Price} / {this.Category} {IsItemNew()}");
        
        }

        public override bool Equals(object? obj)
        {
            return obj is MenuItem item &&
                   Description == item.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Description);
        }
    }
}
