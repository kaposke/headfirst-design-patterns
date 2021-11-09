using System;

namespace pizzaFactory
{
    public class PepperoniPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing pepperoni pizza.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pepperoni pizza.");
        }

        public void Bake()
        {
            Console.WriteLine("Baking pepperoni pizza.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pepperoni pizza.");
        }
    }
}