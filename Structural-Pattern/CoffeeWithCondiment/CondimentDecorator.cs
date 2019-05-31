namespace CoffeeWithCondiment
{
    public abstract class CondimentDecorator : Beverage    
    {
        public new abstract string Description{get;set; }
    }
}