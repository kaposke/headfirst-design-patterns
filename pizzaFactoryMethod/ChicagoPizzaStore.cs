namespace pizzaFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            if (type == "cheese")
                return new CheesePizza(ingredientFactory);
            else if (type == "pepperoni")
                return new PepperoniPizza(ingredientFactory);
            else if (type == "clam")
                return new ClamPizza(ingredientFactory);
            else if (type == "veggie")
                return new VeggiePizza(ingredientFactory);
            else return null;
        }
    }
}