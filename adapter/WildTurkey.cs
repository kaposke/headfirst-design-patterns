namespace adapter
{
    public class WildTurkey : ITurkey
    {

        public void Gobble()
        {
            System.Console.WriteLine("Wild turkey: Gobble!");
        }

        public void Fly()
        {
            System.Console.WriteLine("I'm flying a short distance");
        }
    }
}