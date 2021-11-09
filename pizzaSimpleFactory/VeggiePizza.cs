using System;

namespace pizzaFactory
{
    public class VeggiePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing veggie pizza.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting veggie pizza.");
        }

        public void Bake()
        {
            Console.WriteLine("Baking veggie pizza.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing veggie pizza.");
        }
    }
}