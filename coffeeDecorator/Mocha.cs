namespace coffee
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            _description = "Mocha";
            _beverage = beverage;    
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, {_description}"; 
        }

        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }
    }
}