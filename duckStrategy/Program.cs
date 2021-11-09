namespace duck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck model = new ModelDuck();
            model.PerformQuack();
            model.PerformFly();
            model.FlyBehaviour = new FlyRocketType();
            model.PerformFly();
        }
    }
}
