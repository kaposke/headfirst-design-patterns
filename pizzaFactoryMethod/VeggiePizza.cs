using System;

namespace pizzaFactory
{
    public class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory _ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            Name = "Veggie pizza";
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
            _veggies = _ingredientFactory.CreateVeggies();
        }
    }
}