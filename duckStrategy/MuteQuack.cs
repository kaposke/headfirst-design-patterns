namespace duck
{
    public class MuteQuack : QuackBehaviour
    {
        public void Quack()
        {
            System.Console.WriteLine("...silence...");
        }
    }
}