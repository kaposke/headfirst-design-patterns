using System;

namespace pizzaFactory
{
    public abstract class Pizza
    {
        protected IDough _dough;
        protected ISauce _sauce;
        protected IVeggie[] _veggies;
        protected ICheese _cheese;
        protected IPepperoni _pepperoni;
        protected IClams _clams;

        public string Name { get; protected set; }

        public abstract void Prepare();
        
        public void Bake()
        {
            Console.WriteLine($"Baking {Name}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {Name}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {Name}");
        }

    }
}