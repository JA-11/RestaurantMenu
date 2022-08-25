using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    public class Restaurant
    {
        public static void Main(string[] args)
        {
            MenuItem pizza = new MenuItem(10, "Pizza", "main course", false);
            MenuItem pasta = new MenuItem(15, "Pasta", "main course", true);
            MenuItem brownie = new MenuItem(7, "Brownie", "dessert", true);
            MenuItem nachos = new MenuItem(5, "Nachos", "appetizer", false);
            MenuItem pizza2 = new MenuItem(10, "Pizza", "main course", false);

            List<MenuItem> menuitems = new List<MenuItem>();

            Menu GoodFoodInc = new Menu(menuitems, new DateTime(2022, 8, 24));

            GoodFoodInc.DateTimeUpdate();
                        
            GoodFoodInc.AddToMenu(pizza);
            GoodFoodInc.AddToMenu(pasta);
            GoodFoodInc.AddToMenu(brownie);
            GoodFoodInc.AddToMenu(nachos);
            GoodFoodInc.AddToMenu(pizza2);

            //GoodFoodInc.PrintMenu();

            //pasta.PrintMenuItem();

            GoodFoodInc.RemoveFromMenu(pizza);

            GoodFoodInc.PrintMenu();

            Console.WriteLine($"Menu last updated: {GoodFoodInc.LastUpdated}");

            Console.WriteLine("\n");
            Console.WriteLine(pizza == pasta);
            Console.WriteLine(pizza.Equals(pizza2));
        }
    }
}
