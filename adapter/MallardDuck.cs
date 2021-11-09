using System;

namespace adapter
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Mallard duck: Quack!");
        }

        public void Fly()
        {
            Console.WriteLine("Mallard duck Flying!");
        }
    }
}