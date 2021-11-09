namespace coffee
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;

        public override Size GetSize()
        {
            return _beverage.GetSize();
        }
    }
}