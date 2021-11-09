namespace coffee
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            _description = "Expresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}