using System;

namespace pizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYStylePizzaStore();
            nyStore.OrderPizza("pepperoni");

            PizzaStore chicagoStore = new ChicagoPizzaStore();
            chicagoStore.OrderPizza("pepperoni");
        }
    }
}
