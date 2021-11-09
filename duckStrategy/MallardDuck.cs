namespace duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new Quack();    
        }

        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("Mallard Duck");
        }
    }
}