namespace coffee
{
    public abstract class Beverage
    {
        public enum Size 
        {
            TALL,
            GRANDE,
            VENTI
        }
        private Size _size = Size.TALL;
        protected string _description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return _description;
        }

        public virtual Size GetSize()
        {
            return _size;
        }

        public void SetSize(Size size)
        {
            _size = size;
        }

        public abstract double Cost();
    }
}