using System;

namespace pizzaFactory
{
    public class ClamPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing clam pizza.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting clam pizza.");
        }

        public void Bake()
        {
            Console.WriteLine("Baking clam pizza.");
        }

        public void Box()
        {
            Console.WriteLine("Boxing clam pizza.");
        }
    }
}