namespace coffee
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            _description = "Soy";
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, {_description}";
        }

        public override double Cost()
        {
            double cost = _beverage.Cost();
            if (_beverage.GetSize() == Size.TALL)
                cost += .10;
            if (_beverage.GetSize() == Size.GRANDE)
                cost += .15;
            if (_beverage.GetSize() == Size.VENTI)
                cost += .20;
            return cost;
        }
    }
}