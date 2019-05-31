namespace CoffeeWithCondiment
{
    public abstract class Beverage
    {
        protected string description = "Unknow Beverage";
        public string Description
        {
            get { return description; }
        }

        public abstract double Cost();
    }
}