namespace pizzaFactory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IVeggie[] CreateVeggies();
        IPepperoni CreatePepperoni();
        IClams CreateClams();
    }
}