namespace iterator
{
    public class Waitress
    {
        public DinerMenu DinerMenu { get; set; }
        public PancakeHouseMenu PancakeHouseMenu { get; set; }
        
        public Waitress()
        {
            DinerMenu = new DinerMenu();
            PancakeHouseMenu = new PancakeHouseMenu();
        }

        public void PrintMenu()
        {
            MenuItem[] dinerItems = DinerMenu.MenuItems;
            for (var i = 0; i < dinerItems.Length; i++)
            {
                
            }
        }
    }
}