namespace pizzaFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClams CreateClams()
        {
            return new FreshClams();
        }

        public IPepperoni CreatePepperoni()
        {
            return new Pepperoni();
        }

        public IVeggie[] CreateVeggies()
        {
            return new IVeggie[] {};
        }
    }
}