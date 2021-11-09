using System;

namespace iterator
{
    public class DinerMenu
    {
        const int MAX_ITEMS = 6;
        private int _numberOfItems = 0;
        public MenuItem[] MenuItems { get; private set; }

        public DinerMenu()
        {
            MenuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT",
                "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99M);

            AddItem("BLT",
                "Bacon with lettuce & tomato on whole wheat", false, 2.99M);

            AddItem("Soup of the day",
                "Soup of the day, with a side of potato salad", false, 3.29M);

            AddItem("Hotdog",
                "A hot dog, with sauerkraut, relish, onions, topped with cheese",
                false, 3.05M);
            // a couple of other Diner Menu items added here
        }

        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                MenuItems[_numberOfItems] = menuItem;
                _numberOfItems = _numberOfItems + 1;
            }
        }
    }
}