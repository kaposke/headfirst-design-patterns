namespace duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new Quack();
        }

        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("I'm a model duck");
        }
    }
}