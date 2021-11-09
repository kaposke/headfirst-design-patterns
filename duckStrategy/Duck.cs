using System;

namespace duck
{
    public class Duck
    {
        public FlyBehaviour FlyBehaviour { get; set; }
        
        public QuackBehaviour QuackBehaviour { get; set; }

        public virtual void Display() {}
        
        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            QuackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Swiming!");
        }
    }
}
