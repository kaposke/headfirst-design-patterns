using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck mallard = new MallardDuck();
            
            ITurkey turkey = new WildTurkey();
            TurkeyAdapter adapter = new(turkey);

            System.Console.WriteLine("The turkey says: ");
            turkey.Gobble();
            turkey.Fly();

            System.Console.WriteLine("The duck says: ");
            TestDuck(mallard);

            System.Console.WriteLine("The adapter says: ");
            TestDuck(adapter);
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
