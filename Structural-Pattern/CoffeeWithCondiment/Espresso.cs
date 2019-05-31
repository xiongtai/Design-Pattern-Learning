namespace CoffeeWithCondiment
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espress0";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}