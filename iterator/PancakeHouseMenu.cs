using System.Collections.Generic;

namespace iterator
{
    public class PancakeHouseMenu
    {
        public List<MenuItem> MenuItems { get; private set; } = new List<MenuItem>();

        public PancakeHouseMenu()
        {
            AddItem("K&B's Pancake Breakfast",
                    "Pancakes with scrambled eggs and toast",
                    true,
                    2.99M);
                    
            AddItem("Regular Pancake Breakfast",
                    "Pancakes with fried eggs, sausage",
                    false,
                    2.99M);

            AddItem("Blueberry Pancakes",
                    "Pancakes made with fresh blueberries",
                    true,
                    3.49M);

            AddItem("Waffles",
                    "Waffles with your choice of blueberries or strawberries",
                    true,
                    3.59M);
        }

        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem);
        }
    }
}