namespace pizzaFactory
{
    public class SimplePizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            IPizza pizza = null;

            if (type == "cheese")
                pizza = new CheesePizza();
            else if (type == "pepperoni")
                pizza = new PepperoniPizza();
            else if (type == "clam")
                pizza = new ClamPizza();
            else if (type == "veggie")
                pizza = new VeggiePizza();

            return pizza;
        }
    }
}