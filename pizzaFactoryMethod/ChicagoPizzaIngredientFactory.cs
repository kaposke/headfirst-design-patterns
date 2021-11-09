namespace pizzaFactory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams CreateClams()
        {
            return new FrozenClams();
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