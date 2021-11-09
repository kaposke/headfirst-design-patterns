namespace coffee
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            _description = "Whip";
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, {_description}";
        }

        public override double Cost()
        {
            return _beverage.Cost() + .10;
        }
    }
}