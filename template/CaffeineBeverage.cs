using System;

namespace template
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (UserWantsCondiments())
                AddCondiments();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        // This is a hook (override is optional)
        protected virtual bool UserWantsCondiments()
        {
            return true;
        }
    }
}